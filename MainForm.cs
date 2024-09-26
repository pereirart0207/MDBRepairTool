using System;
using System.Runtime.InteropServices;
using System.IO; // Para manejar archivos y directorios
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Access;

namespace MDBRepairTool
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Método para reparar el archivo MDB
        private void RepairMDB(string mdbFilePath)
        {
            var accessApp = new Microsoft.Office.Interop.Access.Application();
            
            // Extraer la ruta y el nombre del archivo sin la extensión
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(mdbFilePath);
            string directoryPath = Path.GetDirectoryName(mdbFilePath);

            if (string.IsNullOrEmpty(fileNameWithoutExtension))
            {
                MessageBox.Show("El nombre del archivo no es válido.");
                return;
            }

            // Crear el archivo temporal reparado
            string repairedFilePath = Path.Combine(directoryPath, fileNameWithoutExtension + "_temp.mdb");

            try
            {
                // Usar el método CompactRepair para reparar la base de datos en un archivo temporal
                accessApp.CompactRepair(mdbFilePath, repairedFilePath, false);

                // Eliminar el archivo original y renombrar el reparado como el original
                File.Delete(mdbFilePath); // Borrar el archivo original
                File.Move(repairedFilePath, mdbFilePath); // Renombrar el archivo reparado como el original
            }
            catch (COMException ex)
            {
                throw new Exception("Error al reparar la base de datos: " + ex.Message);
            }
            finally
            {
                accessApp.Quit();
                Marshal.ReleaseComObject(accessApp);
            }
        }

        private async void BtnRepairClick(object sender, EventArgs e)
        {
        	btnRepair.Enabled=false;
            txtResult.Visible = true;
            picProc.Visible = true;

            string mdbFilePath = txtFilePath.Text;

            if (string.IsNullOrEmpty(mdbFilePath))
            {
                SetImage(false);
                MessageBox.Show("Por favor, selecciona un archivo MDB.");
                return;
            }

            // Ejecuta la tarea de reparación en segundo plano
            await Task.Run(() =>
            {
                try
                {
                    RepairMDB(mdbFilePath);

                    // Esto lo hacemos en el hilo principal
                    this.Invoke((Action)(() =>
                    {
                        SetImage(true);
                        txtResult.Text = "Archivo MDB reparado exitosamente.\n";
                    }));
                }
                catch (Exception ex)
                {
                    // Esto lo hacemos en el hilo principal
                    this.Invoke((Action)(() =>
                    {
                        SetImage(false);
                        txtResult.Text = "Error al intentar reparar el archivo:\n" + ex.Message + "\n";
                    }));
                }
            });

            picProc.Visible = false;
        }

        void BtnSelectFileClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos MDB (*.mdb)|*.mdb|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Selecciona un archivo MDB";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        // Método para manejar la visibilidad de imágenes de estado
        void SetImage(bool ok)
        {
        	btnRepair.Enabled = true;
            picProc.Visible = false;

            if (ok)
            {
                picOk.Visible = true;
                picErr.Visible = false;
            }
            else
            {
                picOk.Visible = false;
                picErr.Visible = true;
            }
        }
    }
}
