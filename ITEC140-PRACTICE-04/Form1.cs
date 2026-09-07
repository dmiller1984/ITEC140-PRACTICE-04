namespace ITEC140_PRACTICE_04;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void btnCreateSummary_Click(object sender, EventArgs e)
    {
        string workerName = txtWorkerName.Text.Trim();
        if (workerName == "")
        {
            lblsummary.Text = "Enter a workername.";
            return;
        }
        string shift = "";
        if (radDay.Checked)
        {
            shift = "Day";
        }
        else if (radEvening.Checked)
        {
            shift = "Evening";
        }
        else if (radNight.Checked)
        {
            shift = "Night";
        }
        else
        {
            lblsummary.Text = "Chooce a shift.";
            return;
        }
        if (chkPpeComplete.Checked == false)
        {
            lblsummary.Text = "Complete the PPE inspection.";
            return;
        }
        lblsummary.Text = "Worker: " + workerName;
        lblsummary.Text += "\nShift: " + shift;
        lblsummary.Text += "\nPPEinspection complete.";
    }
}

