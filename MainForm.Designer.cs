/*
 * Created by SharpDevelop.
 * User: TONY
 * Date: 25/09/2024
 * Time: 13:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MDBRepairTool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.btnRepair = new System.Windows.Forms.Button();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.txtResult = new System.Windows.Forms.Label();
			this.picOk = new System.Windows.Forms.PictureBox();
			this.picErr = new System.Windows.Forms.PictureBox();
			this.picProc = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picOk)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picErr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picProc)).BeginInit();
			this.SuspendLayout();
			// 
			// txtFilePath
			// 
			this.txtFilePath.Enabled = false;
			this.txtFilePath.Location = new System.Drawing.Point(12, 21);
			this.txtFilePath.Multiline = true;
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(194, 34);
			this.txtFilePath.TabIndex = 0;
			// 
			// btnRepair
			// 
			this.btnRepair.Location = new System.Drawing.Point(12, 107);
			this.btnRepair.Name = "btnRepair";
			this.btnRepair.Size = new System.Drawing.Size(233, 32);
			this.btnRepair.TabIndex = 2;
			this.btnRepair.Text = "REPAIR";
			this.btnRepair.UseVisualStyleBackColor = true;
			this.btnRepair.Click += new System.EventHandler(this.BtnRepairClick);
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFile.Image")));
			this.btnSelectFile.Location = new System.Drawing.Point(212, 21);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(33, 34);
			this.btnSelectFile.TabIndex = 3;
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFileClick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(38, 77);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(206, 20);
			this.txtResult.TabIndex = 4;
			this.txtResult.Text = "Procesando...";
			this.txtResult.Visible = false;
			// 
			// picOk
			// 
			this.picOk.Image = ((System.Drawing.Image)(resources.GetObject("picOk.Image")));
			this.picOk.Location = new System.Drawing.Point(12, 73);
			this.picOk.Name = "picOk";
			this.picOk.Size = new System.Drawing.Size(20, 20);
			this.picOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picOk.TabIndex = 5;
			this.picOk.TabStop = false;
			this.picOk.Visible = false;
			// 
			// picErr
			// 
			this.picErr.Image = ((System.Drawing.Image)(resources.GetObject("picErr.Image")));
			this.picErr.Location = new System.Drawing.Point(12, 73);
			this.picErr.Name = "picErr";
			this.picErr.Size = new System.Drawing.Size(20, 20);
			this.picErr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picErr.TabIndex = 6;
			this.picErr.TabStop = false;
			this.picErr.Visible = false;
			// 
			// picProc
			// 
			this.picProc.Image = ((System.Drawing.Image)(resources.GetObject("picProc.Image")));
			this.picProc.Location = new System.Drawing.Point(12, 73);
			this.picProc.Name = "picProc";
			this.picProc.Size = new System.Drawing.Size(20, 20);
			this.picProc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picProc.TabIndex = 7;
			this.picProc.TabStop = false;
			this.picProc.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 162);
			this.Controls.Add(this.picProc);
			this.Controls.Add(this.picErr);
			this.Controls.Add(this.picOk);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.btnSelectFile);
			this.Controls.Add(this.btnRepair);
			this.Controls.Add(this.txtFilePath);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "MDBRepairTool";
			((System.ComponentModel.ISupportInitialize)(this.picOk)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picErr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picProc)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox picProc;
		private System.Windows.Forms.PictureBox picErr;
		private System.Windows.Forms.PictureBox picOk;
		private System.Windows.Forms.Label txtResult;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.Button btnRepair;
		private System.Windows.Forms.TextBox txtFilePath;
	}
}
