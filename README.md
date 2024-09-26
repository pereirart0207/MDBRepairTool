MDBRepairTool
MDBRepairTool is a simple tool for repairing corrupted Microsoft Access Database (.mdb) files. This Windows Forms application uses the Microsoft Office Interop API to automate the repair process.

Features
Repair MDB Files: It utilizes the CompactRepair method provided by Microsoft Access to repair the database.
Automated Workflow: Automatically renames the repaired file and replaces the original.
File Selection: A user-friendly interface for selecting .mdb files via an Open File Dialog.
Background Processing: Repairs are performed asynchronously to ensure the UI remains responsive.
Visual Feedback: Provides visual indicators to show success or failure of the repair operation.
Requirements
.NET Framework (version compatible with Windows Forms and Interop).
Microsoft Access (for Access Interop API).
Microsoft Office Interop Library for Access.
How It Works
Select MDB File: The user can select an .mdb file using the "Select File" button.
Repair Process: Once the file is selected, clicking the "Repair" button will start the repair process in the background.
Repaired File: The tool repairs the file, creates a temporary version, deletes the original, and renames the temporary file back to the original name.
Visual Feedback: After the repair, the user will receive feedback on whether the repair was successful or if an error occurred.
Installation
Clone the repository:

bash
Copiar código
git clone https://github.com/pereirart0207/MDBRepairTool.git
Open the solution in SharpDevelop or Visual Studio.

Ensure that you have the required Microsoft Office Interop libraries installed. You can add these via NuGet or by referencing the correct assemblies in your project.

Build the project and run.

Usage
Launch the application.
Click the "Select File" button to choose an .mdb file from your system.
Once the file is selected, click "Repair".
Wait for the process to complete. A success message will appear if the file was repaired successfully, or an error message will appear if the repair failed.
Code Overview
The core logic of the tool is in the RepairMDB method. This method:

Opens the .mdb file using the Microsoft.Office.Interop.Access.Application.
Uses the CompactRepair method to repair the database.
Replaces the original file with the repaired one.
Error handling is done using a try-catch block to catch COMException and other potential issues during the repair process.

Example Code Snippet:
csharp
Copiar código
// Method to repair the MDB file
private void RepairMDB(string mdbFilePath)
{
    var accessApp = new Microsoft.Office.Interop.Access.Application();
    
    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(mdbFilePath);
    string directoryPath = Path.GetDirectoryName(mdbFilePath);

    string repairedFilePath = Path.Combine(directoryPath, fileNameWithoutExtension + "_temp.mdb");

    try
    {
        accessApp.CompactRepair(mdbFilePath, repairedFilePath, false);

        File.Delete(mdbFilePath);
        File.Move(repairedFilePath, mdbFilePath);
    }
    catch (COMException ex)
    {
        throw new Exception("Error repairing the database: " + ex.Message);
    }
    finally
    {
        accessApp.Quit();
        Marshal.ReleaseComObject(accessApp);
    }
}
Contributing
If you would like to contribute to this project, feel free to submit a pull request or open an issue to discuss potential changes.

License
This project is licensed under the MIT License - see the LICENSE file for details.

