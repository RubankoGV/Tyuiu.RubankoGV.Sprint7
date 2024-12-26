using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.RubankoGV.Sprint7.V8;
partial class FormGuide
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
        labelGuide_RGV = new Label();
        buttonClose_RGV = new Button();
        SuspendLayout();
        // 
        // labelGuide_RGV
        // 
        labelGuide_RGV.AutoSize = true;
        labelGuide_RGV.Font = new System.Drawing.Font("Times New Roman", 10F, FontStyle.Italic);
        labelGuide_RGV.Location = new Point(-69, 19);
        labelGuide_RGV.Name = "labelGuide_RGV";
        labelGuide_RGV.Size = new Size(757, 272);
        labelGuide_RGV.TabIndex = 0;
        labelGuide_RGV.Text = resources.GetString("labelGuide_RGV.Text");
        // 
        // buttonClose_RGV
        // 
        buttonClose_RGV.Location = new Point(607, 307);
        buttonClose_RGV.Margin = new Padding(3, 2, 3, 2);
        buttonClose_RGV.Name = "buttonClose_RGV";
        buttonClose_RGV.Size = new Size(82, 22);
        buttonClose_RGV.TabIndex = 1;
        buttonClose_RGV.Text = "ОК";
        buttonClose_RGV.UseVisualStyleBackColor = true;
        buttonClose_RGV.Click += buttonClose_RGV_Click;
        // 
        // FormGuide
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(700, 338);
        Controls.Add(buttonClose_RGV);
        Controls.Add(labelGuide_RGV);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormGuide";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Руководство";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelGuide_RGV;
    private Button buttonClose_RGV;
}
