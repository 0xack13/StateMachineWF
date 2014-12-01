using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceClaimWF
{
    public partial class Form1 : Form
    {
        WorkflowRuntime workflowRuntime = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            workflowRuntime = new WorkflowRuntime();
            workflowRuntime.StartRuntime();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //workflowRuntime = new WorkflowRuntime();
            workflowRuntime.StopRuntime();

        }

    }
}
