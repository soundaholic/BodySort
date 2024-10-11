using INFITF;
using MECMOD;
using PARTITF;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BodySort
{
    public partial class Form1 : Form
    {
        INFITF.Application _Catia;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            PartDocument oPartDocument = _Catia.ActiveDocument as PartDocument;
            Part oPart = oPartDocument.Part;
            ShapeFactory shapeFactory = oPart.ShapeFactory as ShapeFactory;
            Bodies cBodies = oPart.Bodies;
            Body targetBody = null;
            Selection oSelection = _Catia.ActiveDocument.Selection;

            if (radioButton_newBody.Checked)
            {
                targetBody = cBodies.Add();
                targetBody.set_Name("Asm_1");
            }
            else if (radioButton_existBody.Checked)
            {
                object[] iFilterType = new object[1] { "Body" };

                oSelection.SelectElement2(iFilterType, "Select an Element", false);

                targetBody = (Body)oSelection.Item2(1).Value;
            }

            oSelection.Clear();

            object[] anyObjFilter = new object[] { "Solid" };

            oSelection.SelectElement3(anyObjFilter, "Select solids and confirm ;)", false, CATMultiSelectionMode.CATMultiSelTriggWhenUserValidatesSelection, false);

            MessageBox.Show("Please let the process be over and don't click in CATIA Window", "Don't touch CATIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ProgressDialog progressDialog = new ProgressDialog();

            for (int i = 1; i <= oSelection.Count; i++)
            {
                Body xBody = (Body)oSelection.FindObject("CATIABody");
                progressDialog.UpdateProgress(i, oSelection.Count);
                oSelection.Add(xBody);
                shapeFactory.AddNewAssemble(xBody);
                oPart.Update();
            }

            oPart.InWorkObject = targetBody;
           
            progressDialog.Close();
            oPart.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _Catia = (INFITF.Application)Marshal.GetActiveObject("CATIA.Application");
            }
            catch
            {
                MessageBox.Show("Please start any CATIA Application");
                return;
            }
            if (!(_Catia.ActiveDocument is PartDocument))
            {
                MessageBox.Show("Active document is not a PartDocument!");
                Close();
            }
        }
    }
}
