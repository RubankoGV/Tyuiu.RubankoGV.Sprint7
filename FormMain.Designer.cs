using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.RubankoGV.Sprint7.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStripTools_RGV = new MenuStrip();
            programToolStripMenuItem_RGV = new ToolStripMenuItem();
            statsToolStripMenuItem_RGV = new ToolStripMenuItem();
            toolStripSeparator_RGV = new ToolStripSeparator();
            exitToolStripMenuItem_RGV = new ToolStripMenuItem();
            filterToolStripMenuItem_RGV = new ToolStripMenuItem();
            redRowsToolStripMenuItem_RGV = new ToolStripMenuItem();
            aquaRowsToolStripMenuItem_RGV = new ToolStripMenuItem();
            helpToolStripMenuItem_RGV = new ToolStripMenuItem();
            infoToolStripMenuItem_RGV = new ToolStripMenuItem();
            guideToolStripMenuItem_RGV = new ToolStripMenuItem();
            splitContainerTask_RGV = new SplitContainer();
            groupBoxData_RGV = new GroupBox();
            tabControlData_RGV = new TabControl();
            autoTab_RGV = new TabPage();
            dataGridViewAuto_RGV = new DataGridView();
            changedAutoTab_RGV = new TabPage();
            dataGridViewChanged_RGV = new DataGridView();
            driverNoChanged_RGV = new DataGridViewTextBoxColumn();
            autoNumberChanged_RGV = new DataGridViewTextBoxColumn();
            autoMarkChanged_RGV = new DataGridViewTextBoxColumn();
            technicalConditionChanged_RGV = new DataGridViewTextBoxColumn();
            autoLocationnChanged_RGV = new DataGridViewTextBoxColumn();
            autoSpeedChanged_RGV = new DataGridViewTextBoxColumn();
            autoCarryingChanged_RGV = new DataGridViewTextBoxColumn();
            autoFuelChanged_RGV = new DataGridViewTextBoxColumn();
            tabControlSearch_RGV = new TabControl();
            driverNumSearch_RGV = new TabPage();
            buttonSearchDriverNum_RGV = new Button();
            textBoxSearchDriverNum_RGV = new TextBox();
            autoNumbersSearch_RGV = new TabPage();
            buttonSearchAutoNum_RGV = new Button();
            textBoxAutoNumSearch_RGV = new TextBox();
            groupBoxDataGrids_RGV = new GroupBox();
            buttonTrueDelete_RGV = new Button();
            buttonUnMarkDelete_RGV = new Button();
            buttonMarkDelete_RGV = new Button();
            buttonAdd_RGV = new Button();
            buttonRemove_RGV = new Button();
            groupBoxFileActions_RGV = new GroupBox();
            buttonLoad_RGV = new Button();
            buttonSave_RGV = new Button();
            toolTipInfo_RGV = new ToolTip(components);
            saveFileDialogInfo_RGV = new SaveFileDialog();
            openFileDialogProject_RGV = new OpenFileDialog();
            driverNo_RGV = new DataGridViewTextBoxColumn();
            autoNumber_RGV = new DataGridViewTextBoxColumn();
            autoMark_RGV = new DataGridViewTextBoxColumn();
            technicalCondition_RGV = new DataGridViewTextBoxColumn();
            autoLocation_RGV = new DataGridViewTextBoxColumn();
            autoSpeed_RGV = new DataGridViewTextBoxColumn();
            autoCarrying_RGV = new DataGridViewTextBoxColumn();
            autoFuel_RGV = new DataGridViewTextBoxColumn();
            menuStripTools_RGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTask_RGV).BeginInit();
            splitContainerTask_RGV.Panel1.SuspendLayout();
            splitContainerTask_RGV.Panel2.SuspendLayout();
            splitContainerTask_RGV.SuspendLayout();
            groupBoxData_RGV.SuspendLayout();
            tabControlData_RGV.SuspendLayout();
            autoTab_RGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuto_RGV).BeginInit();
            changedAutoTab_RGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChanged_RGV).BeginInit();
            tabControlSearch_RGV.SuspendLayout();
            driverNumSearch_RGV.SuspendLayout();
            autoNumbersSearch_RGV.SuspendLayout();
            groupBoxDataGrids_RGV.SuspendLayout();
            groupBoxFileActions_RGV.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTools_RGV
            // 
            menuStripTools_RGV.BackColor = SystemColors.ActiveCaption;
            menuStripTools_RGV.Dock = DockStyle.Bottom;
            menuStripTools_RGV.GripStyle = ToolStripGripStyle.Visible;
            menuStripTools_RGV.ImageScalingSize = new Size(20, 20);
            menuStripTools_RGV.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem_RGV, filterToolStripMenuItem_RGV, helpToolStripMenuItem_RGV });
            menuStripTools_RGV.Location = new Point(0, 357);
            menuStripTools_RGV.Name = "menuStripTools_RGV";
            menuStripTools_RGV.Size = new Size(1144, 24);
            menuStripTools_RGV.TabIndex = 0;
            menuStripTools_RGV.Text = "menuStrip1";
            // 
            // programToolStripMenuItem_RGV
            // 
            programToolStripMenuItem_RGV.DropDownItems.AddRange(new ToolStripItem[] { statsToolStripMenuItem_RGV, toolStripSeparator_RGV, exitToolStripMenuItem_RGV });
            programToolStripMenuItem_RGV.Name = "programToolStripMenuItem_RGV";
            programToolStripMenuItem_RGV.Size = new Size(84, 20);
            programToolStripMenuItem_RGV.Text = "Программа";
            // 
            // statsToolStripMenuItem_RGV
            // 
            statsToolStripMenuItem_RGV.Enabled = false;
            statsToolStripMenuItem_RGV.Name = "statsToolStripMenuItem_RGV";
            statsToolStripMenuItem_RGV.Size = new Size(135, 22);
            statsToolStripMenuItem_RGV.Text = "Статистика";
            statsToolStripMenuItem_RGV.ToolTipText = "Показать статистику по таблице";
            statsToolStripMenuItem_RGV.Click += statsToolStripMenuItem_RGV_Click;
            // 
            // toolStripSeparator_RGV
            // 
            toolStripSeparator_RGV.Name = "toolStripSeparator_RGV";
            toolStripSeparator_RGV.Size = new Size(132, 6);
            // 
            // exitToolStripMenuItem_RGV
            // 
            exitToolStripMenuItem_RGV.Name = "exitToolStripMenuItem_RGV";
            exitToolStripMenuItem_RGV.Size = new Size(135, 22);
            exitToolStripMenuItem_RGV.Text = "Выход";
            exitToolStripMenuItem_RGV.ToolTipText = "Выйти из приложения";
            exitToolStripMenuItem_RGV.Click += exitToolStripMenuItem_RGV_Click;
            // 
            // filterToolStripMenuItem_RGV
            // 
            filterToolStripMenuItem_RGV.DropDownItems.AddRange(new ToolStripItem[] { redRowsToolStripMenuItem_RGV, aquaRowsToolStripMenuItem_RGV });
            filterToolStripMenuItem_RGV.Name = "filterToolStripMenuItem_RGV";
            filterToolStripMenuItem_RGV.Size = new Size(60, 20);
            filterToolStripMenuItem_RGV.Text = "Фильтр";
            filterToolStripMenuItem_RGV.Click += filterToolStripMenuItem_RGV_Click;
            // 
            // redRowsToolStripMenuItem_RGV
            // 
            redRowsToolStripMenuItem_RGV.Checked = true;
            redRowsToolStripMenuItem_RGV.CheckState = CheckState.Checked;
            redRowsToolStripMenuItem_RGV.Enabled = false;
            redRowsToolStripMenuItem_RGV.Name = "redRowsToolStripMenuItem_RGV";
            redRowsToolStripMenuItem_RGV.Size = new Size(191, 22);
            redRowsToolStripMenuItem_RGV.Text = "Удаленные строки";
            redRowsToolStripMenuItem_RGV.ToolTipText = "Показать\\скрыть удаленные строки";
            redRowsToolStripMenuItem_RGV.Click += redRowsToolStripMenuItem_RGV_Click;
            // 
            // aquaRowsToolStripMenuItem_RGV
            // 
            aquaRowsToolStripMenuItem_RGV.Checked = true;
            aquaRowsToolStripMenuItem_RGV.CheckState = CheckState.Checked;
            aquaRowsToolStripMenuItem_RGV.Enabled = false;
            aquaRowsToolStripMenuItem_RGV.Name = "aquaRowsToolStripMenuItem_RGV";
            aquaRowsToolStripMenuItem_RGV.Size = new Size(191, 22);
            aquaRowsToolStripMenuItem_RGV.Text = "Добавленные строки";
            aquaRowsToolStripMenuItem_RGV.ToolTipText = "Показать\\скрыть добавленные строки";
            aquaRowsToolStripMenuItem_RGV.Click += aquaRowsToolStripMenuItem_RGV_Click;
            // 
            // helpToolStripMenuItem_RGV
            // 
            helpToolStripMenuItem_RGV.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem_RGV, guideToolStripMenuItem_RGV });
            helpToolStripMenuItem_RGV.Name = "helpToolStripMenuItem_RGV";
            helpToolStripMenuItem_RGV.Size = new Size(68, 20);
            helpToolStripMenuItem_RGV.Text = "Помощь";
            // 
            // infoToolStripMenuItem_RGV
            // 
            infoToolStripMenuItem_RGV.Name = "infoToolStripMenuItem_RGV";
            infoToolStripMenuItem_RGV.Size = new Size(143, 22);
            infoToolStripMenuItem_RGV.Text = "Справка";
            infoToolStripMenuItem_RGV.ToolTipText = "Справка о создателе";
            infoToolStripMenuItem_RGV.Click += infoToolStripMenuItem_RGV_Click;
            // 
            // guideToolStripMenuItem_RGV
            // 
            guideToolStripMenuItem_RGV.Name = "guideToolStripMenuItem_RGV";
            guideToolStripMenuItem_RGV.Size = new Size(143, 22);
            guideToolStripMenuItem_RGV.Text = "Руководство";
            guideToolStripMenuItem_RGV.ToolTipText = "Руководство пользователя";
            guideToolStripMenuItem_RGV.Click += guideToolStripMenuItem_RGV_Click;
            // 
            // splitContainerTask_RGV
            // 
            splitContainerTask_RGV.Dock = DockStyle.Fill;
            splitContainerTask_RGV.Location = new Point(0, 0);
            splitContainerTask_RGV.Margin = new Padding(3, 2, 3, 2);
            splitContainerTask_RGV.Name = "splitContainerTask_RGV";
            // 
            // splitContainerTask_RGV.Panel1
            // 
            splitContainerTask_RGV.Panel1.Controls.Add(groupBoxData_RGV);
            // 
            // splitContainerTask_RGV.Panel2
            // 
            splitContainerTask_RGV.Panel2.Controls.Add(tabControlSearch_RGV);
            splitContainerTask_RGV.Panel2.Controls.Add(groupBoxDataGrids_RGV);
            splitContainerTask_RGV.Panel2.Controls.Add(groupBoxFileActions_RGV);
            splitContainerTask_RGV.Size = new Size(1144, 357);
            splitContainerTask_RGV.SplitterDistance = 872;
            splitContainerTask_RGV.TabIndex = 1;
            // 
            // groupBoxData_RGV
            // 
            groupBoxData_RGV.Controls.Add(tabControlData_RGV);
            groupBoxData_RGV.Dock = DockStyle.Fill;
            groupBoxData_RGV.ForeColor = SystemColors.ControlText;
            groupBoxData_RGV.Location = new Point(0, 0);
            groupBoxData_RGV.Margin = new Padding(3, 2, 3, 2);
            groupBoxData_RGV.Name = "groupBoxData_RGV";
            groupBoxData_RGV.Padding = new Padding(3, 2, 3, 2);
            groupBoxData_RGV.Size = new Size(872, 357);
            groupBoxData_RGV.TabIndex = 0;
            groupBoxData_RGV.TabStop = false;
            groupBoxData_RGV.Text = "   Данные";
            groupBoxData_RGV.Enter += groupBoxData_RGV_Enter;
            // 
            // tabControlData_RGV
            // 
            tabControlData_RGV.Controls.Add(autoTab_RGV);
            tabControlData_RGV.Controls.Add(changedAutoTab_RGV);
            tabControlData_RGV.Dock = DockStyle.Fill;
            tabControlData_RGV.HotTrack = true;
            tabControlData_RGV.Location = new Point(3, 18);
            tabControlData_RGV.Margin = new Padding(3, 2, 3, 2);
            tabControlData_RGV.Name = "tabControlData_RGV";
            tabControlData_RGV.SelectedIndex = 0;
            tabControlData_RGV.Size = new Size(866, 337);
            tabControlData_RGV.TabIndex = 1;
            tabControlData_RGV.SelectedIndexChanged += tabControlData_RGV_SelectedIndexChanged;
            // 
            // autoTab_RGV
            // 
            autoTab_RGV.Controls.Add(dataGridViewAuto_RGV);
            autoTab_RGV.Location = new Point(4, 24);
            autoTab_RGV.Margin = new Padding(3, 2, 3, 2);
            autoTab_RGV.Name = "autoTab_RGV";
            autoTab_RGV.Padding = new Padding(3, 2, 3, 2);
            autoTab_RGV.Size = new Size(858, 309);
            autoTab_RGV.TabIndex = 0;
            autoTab_RGV.Text = "Автопарк";
            autoTab_RGV.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAuto_RGV
            // 
            dataGridViewAuto_RGV.AllowUserToAddRows = false;
            dataGridViewAuto_RGV.AllowUserToDeleteRows = false;
            dataGridViewAuto_RGV.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewAuto_RGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuto_RGV.Columns.AddRange(new DataGridViewColumn[] { driverNo_RGV, autoNumber_RGV, autoMark_RGV, technicalCondition_RGV, autoLocation_RGV, autoSpeed_RGV, autoCarrying_RGV, autoFuel_RGV });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewAuto_RGV.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewAuto_RGV.Dock = DockStyle.Fill;
            dataGridViewAuto_RGV.Location = new Point(3, 2);
            dataGridViewAuto_RGV.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAuto_RGV.Name = "dataGridViewAuto_RGV";
            dataGridViewAuto_RGV.ReadOnly = true;
            dataGridViewAuto_RGV.RowHeadersVisible = false;
            dataGridViewAuto_RGV.RowHeadersWidth = 51;
            dataGridViewAuto_RGV.Size = new Size(852, 305);
            dataGridViewAuto_RGV.TabIndex = 0;
            dataGridViewAuto_RGV.CellContentClick += dataGridViewAuto_RGV_CellContentClick;
            // 
            // changedAutoTab_RGV
            // 
            changedAutoTab_RGV.Controls.Add(dataGridViewChanged_RGV);
            changedAutoTab_RGV.Location = new Point(4, 24);
            changedAutoTab_RGV.Margin = new Padding(3, 2, 3, 2);
            changedAutoTab_RGV.Name = "changedAutoTab_RGV";
            changedAutoTab_RGV.Padding = new Padding(3, 2, 3, 2);
            changedAutoTab_RGV.Size = new Size(858, 309);
            changedAutoTab_RGV.TabIndex = 1;
            changedAutoTab_RGV.Text = "Изменения в таблице";
            changedAutoTab_RGV.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChanged_RGV
            // 
            dataGridViewChanged_RGV.AllowUserToAddRows = false;
            dataGridViewChanged_RGV.AllowUserToDeleteRows = false;
            dataGridViewChanged_RGV.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewChanged_RGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChanged_RGV.Columns.AddRange(new DataGridViewColumn[] { driverNoChanged_RGV, autoNumberChanged_RGV, autoMarkChanged_RGV, technicalConditionChanged_RGV, autoLocationnChanged_RGV, autoSpeedChanged_RGV, autoCarryingChanged_RGV, autoFuelChanged_RGV });
            dataGridViewChanged_RGV.Dock = DockStyle.Fill;
            dataGridViewChanged_RGV.Location = new Point(3, 2);
            dataGridViewChanged_RGV.Margin = new Padding(3, 2, 3, 2);
            dataGridViewChanged_RGV.Name = "dataGridViewChanged_RGV";
            dataGridViewChanged_RGV.RowHeadersVisible = false;
            dataGridViewChanged_RGV.RowHeadersWidth = 51;
            dataGridViewChanged_RGV.Size = new Size(852, 305);
            dataGridViewChanged_RGV.TabIndex = 1;
            dataGridViewChanged_RGV.CellBeginEdit += dataGridViewChanged_RGV_CellBeginEdit;
            dataGridViewChanged_RGV.CellContentClick += dataGridViewChanged_RGV_CellContentClick;
            dataGridViewChanged_RGV.CellEndEdit += dataGridViewChanged_RGV_CellEndEdit;
            dataGridViewChanged_RGV.EditingControlShowing += dataGridViewChanged_RGV_EditingControlShowing;
            // 
            // driverNoChanged_RGV
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            driverNoChanged_RGV.DefaultCellStyle = dataGridViewCellStyle10;
            driverNoChanged_RGV.FillWeight = 40F;
            driverNoChanged_RGV.HeaderText = "№";
            driverNoChanged_RGV.MinimumWidth = 6;
            driverNoChanged_RGV.Name = "driverNoChanged_RGV";
            driverNoChanged_RGV.Width = 30;
            // 
            // autoNumberChanged_RGV
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoNumberChanged_RGV.DefaultCellStyle = dataGridViewCellStyle11;
            autoNumberChanged_RGV.HeaderText = "Знаки";
            autoNumberChanged_RGV.MinimumWidth = 6;
            autoNumberChanged_RGV.Name = "autoNumberChanged_RGV";
            autoNumberChanged_RGV.Width = 80;
            // 
            // autoMarkChanged_RGV
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoMarkChanged_RGV.DefaultCellStyle = dataGridViewCellStyle12;
            autoMarkChanged_RGV.HeaderText = "Марка";
            autoMarkChanged_RGV.MinimumWidth = 6;
            autoMarkChanged_RGV.Name = "autoMarkChanged_RGV";
            autoMarkChanged_RGV.Width = 90;
            // 
            // technicalConditionChanged_RGV
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            technicalConditionChanged_RGV.DefaultCellStyle = dataGridViewCellStyle13;
            technicalConditionChanged_RGV.HeaderText = "Тех. состояние";
            technicalConditionChanged_RGV.MinimumWidth = 6;
            technicalConditionChanged_RGV.Name = "technicalConditionChanged_RGV";
            technicalConditionChanged_RGV.Width = 125;
            // 
            // autoLocationnChanged_RGV
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoLocationnChanged_RGV.DefaultCellStyle = dataGridViewCellStyle14;
            autoLocationnChanged_RGV.HeaderText = "Место";
            autoLocationnChanged_RGV.MinimumWidth = 6;
            autoLocationnChanged_RGV.Name = "autoLocationnChanged_RGV";
            autoLocationnChanged_RGV.Width = 110;
            // 
            // autoSpeedChanged_RGV
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            autoSpeedChanged_RGV.DefaultCellStyle = dataGridViewCellStyle15;
            autoSpeedChanged_RGV.HeaderText = "Скорость(Км\\ч)";
            autoSpeedChanged_RGV.MinimumWidth = 6;
            autoSpeedChanged_RGV.Name = "autoSpeedChanged_RGV";
            autoSpeedChanged_RGV.Width = 120;
            // 
            // autoCarryingChanged_RGV
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoCarryingChanged_RGV.DefaultCellStyle = dataGridViewCellStyle16;
            autoCarryingChanged_RGV.HeaderText = "Грузоподъем(т)";
            autoCarryingChanged_RGV.MinimumWidth = 6;
            autoCarryingChanged_RGV.Name = "autoCarryingChanged_RGV";
            autoCarryingChanged_RGV.Width = 120;
            // 
            // autoFuelChanged_RGV
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoFuelChanged_RGV.DefaultCellStyle = dataGridViewCellStyle17;
            autoFuelChanged_RGV.HeaderText = "Расход топлива(л\\100км)";
            autoFuelChanged_RGV.MinimumWidth = 6;
            autoFuelChanged_RGV.Name = "autoFuelChanged_RGV";
            autoFuelChanged_RGV.Width = 120;
            // 
            // tabControlSearch_RGV
            // 
            tabControlSearch_RGV.Controls.Add(driverNumSearch_RGV);
            tabControlSearch_RGV.Controls.Add(autoNumbersSearch_RGV);
            tabControlSearch_RGV.Enabled = false;
            tabControlSearch_RGV.HotTrack = true;
            tabControlSearch_RGV.Location = new Point(19, 2);
            tabControlSearch_RGV.Margin = new Padding(3, 2, 3, 2);
            tabControlSearch_RGV.Name = "tabControlSearch_RGV";
            tabControlSearch_RGV.SelectedIndex = 0;
            tabControlSearch_RGV.Size = new Size(226, 94);
            tabControlSearch_RGV.TabIndex = 9;
            // 
            // driverNumSearch_RGV
            // 
            driverNumSearch_RGV.BackColor = SystemColors.ActiveCaption;
            driverNumSearch_RGV.Controls.Add(buttonSearchDriverNum_RGV);
            driverNumSearch_RGV.Controls.Add(textBoxSearchDriverNum_RGV);
            driverNumSearch_RGV.Location = new Point(4, 24);
            driverNumSearch_RGV.Margin = new Padding(3, 2, 3, 2);
            driverNumSearch_RGV.Name = "driverNumSearch_RGV";
            driverNumSearch_RGV.Padding = new Padding(3, 2, 3, 2);
            driverNumSearch_RGV.Size = new Size(218, 66);
            driverNumSearch_RGV.TabIndex = 0;
            driverNumSearch_RGV.Text = "По номеру";
            // 
            // buttonSearchDriverNum_RGV
            // 
            buttonSearchDriverNum_RGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSearchDriverNum_RGV.BackColor = SystemColors.ActiveCaption;
            buttonSearchDriverNum_RGV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearchDriverNum_RGV.Image = Properties.Resources.icons8_magnifier_32;
            buttonSearchDriverNum_RGV.Location = new Point(143, 4);
            buttonSearchDriverNum_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonSearchDriverNum_RGV.Name = "buttonSearchDriverNum_RGV";
            buttonSearchDriverNum_RGV.Size = new Size(69, 58);
            buttonSearchDriverNum_RGV.TabIndex = 5;
            toolTipInfo_RGV.SetToolTip(buttonSearchDriverNum_RGV, "Найти ряд по номеру водителя");
            buttonSearchDriverNum_RGV.UseVisualStyleBackColor = false;
            buttonSearchDriverNum_RGV.Click += buttonSearchDriverNum_RGV_Click;
            buttonSearchDriverNum_RGV.MouseEnter += buttonSearchDriverNum_RGV_MouseEnter;
            // 
            // textBoxSearchDriverNum_RGV
            // 
            textBoxSearchDriverNum_RGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchDriverNum_RGV.BackColor = SystemColors.InactiveCaption;
            textBoxSearchDriverNum_RGV.Location = new Point(17, 26);
            textBoxSearchDriverNum_RGV.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchDriverNum_RGV.Name = "textBoxSearchDriverNum_RGV";
            textBoxSearchDriverNum_RGV.Size = new Size(121, 23);
            textBoxSearchDriverNum_RGV.TabIndex = 4;
            // 
            // autoNumbersSearch_RGV
            // 
            autoNumbersSearch_RGV.BackColor = SystemColors.ActiveCaption;
            autoNumbersSearch_RGV.Controls.Add(buttonSearchAutoNum_RGV);
            autoNumbersSearch_RGV.Controls.Add(textBoxAutoNumSearch_RGV);
            autoNumbersSearch_RGV.Location = new Point(4, 24);
            autoNumbersSearch_RGV.Margin = new Padding(3, 2, 3, 2);
            autoNumbersSearch_RGV.Name = "autoNumbersSearch_RGV";
            autoNumbersSearch_RGV.Padding = new Padding(3, 2, 3, 2);
            autoNumbersSearch_RGV.Size = new Size(218, 66);
            autoNumbersSearch_RGV.TabIndex = 1;
            autoNumbersSearch_RGV.Text = "По знакам";
            // 
            // buttonSearchAutoNum_RGV
            // 
            buttonSearchAutoNum_RGV.BackColor = SystemColors.ActiveCaption;
            buttonSearchAutoNum_RGV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearchAutoNum_RGV.Image = Properties.Resources.icons8_magnifier_32;
            buttonSearchAutoNum_RGV.Location = new Point(143, 4);
            buttonSearchAutoNum_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonSearchAutoNum_RGV.Name = "buttonSearchAutoNum_RGV";
            buttonSearchAutoNum_RGV.Size = new Size(69, 58);
            buttonSearchAutoNum_RGV.TabIndex = 5;
            toolTipInfo_RGV.SetToolTip(buttonSearchAutoNum_RGV, "Найти ряд по знакам машины");
            buttonSearchAutoNum_RGV.UseVisualStyleBackColor = false;
            buttonSearchAutoNum_RGV.Click += buttonSearchAutoNum_RGV_Click;
            buttonSearchAutoNum_RGV.MouseEnter += buttonSearchAutoNum_RGV_MouseEnter;
            // 
            // textBoxAutoNumSearch_RGV
            // 
            textBoxAutoNumSearch_RGV.BackColor = SystemColors.InactiveCaption;
            textBoxAutoNumSearch_RGV.Location = new Point(17, 26);
            textBoxAutoNumSearch_RGV.Margin = new Padding(3, 2, 3, 2);
            textBoxAutoNumSearch_RGV.Name = "textBoxAutoNumSearch_RGV";
            textBoxAutoNumSearch_RGV.Size = new Size(121, 23);
            textBoxAutoNumSearch_RGV.TabIndex = 4;
            // 
            // groupBoxDataGrids_RGV
            // 
            groupBoxDataGrids_RGV.Controls.Add(buttonTrueDelete_RGV);
            groupBoxDataGrids_RGV.Controls.Add(buttonUnMarkDelete_RGV);
            groupBoxDataGrids_RGV.Controls.Add(buttonMarkDelete_RGV);
            groupBoxDataGrids_RGV.Controls.Add(buttonAdd_RGV);
            groupBoxDataGrids_RGV.Controls.Add(buttonRemove_RGV);
            groupBoxDataGrids_RGV.Location = new Point(19, 227);
            groupBoxDataGrids_RGV.Margin = new Padding(3, 2, 3, 2);
            groupBoxDataGrids_RGV.Name = "groupBoxDataGrids_RGV";
            groupBoxDataGrids_RGV.Padding = new Padding(3, 2, 3, 2);
            groupBoxDataGrids_RGV.Size = new Size(228, 107);
            groupBoxDataGrids_RGV.TabIndex = 7;
            groupBoxDataGrids_RGV.TabStop = false;
            groupBoxDataGrids_RGV.Text = "Работа с таблицей";
            // 
            // buttonTrueDelete_RGV
            // 
            buttonTrueDelete_RGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonTrueDelete_RGV.BackColor = SystemColors.ActiveCaption;
            buttonTrueDelete_RGV.BackgroundImage = Properties.Resources.icons8_error_32;
            buttonTrueDelete_RGV.BackgroundImageLayout = ImageLayout.Stretch;
            buttonTrueDelete_RGV.Enabled = false;
            buttonTrueDelete_RGV.Location = new Point(100, 43);
            buttonTrueDelete_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonTrueDelete_RGV.Name = "buttonTrueDelete_RGV";
            buttonTrueDelete_RGV.Size = new Size(30, 25);
            buttonTrueDelete_RGV.TabIndex = 5;
            toolTipInfo_RGV.SetToolTip(buttonTrueDelete_RGV, "Окончательно удалить ряд");
            buttonTrueDelete_RGV.UseVisualStyleBackColor = false;
            buttonTrueDelete_RGV.Visible = false;
            buttonTrueDelete_RGV.Click += buttonTrueDelete_RGV_Click;
            buttonTrueDelete_RGV.MouseEnter += buttonTrueDelete_RGV_MouseEnter;
            // 
            // buttonUnMarkDelete_RGV
            // 
            buttonUnMarkDelete_RGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonUnMarkDelete_RGV.AutoSize = true;
            buttonUnMarkDelete_RGV.BackColor = SystemColors.ActiveCaption;
            buttonUnMarkDelete_RGV.BackgroundImage = Properties.Resources.icons8_tick_32;
            buttonUnMarkDelete_RGV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUnMarkDelete_RGV.Enabled = false;
            buttonUnMarkDelete_RGV.Location = new Point(175, 0);
            buttonUnMarkDelete_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonUnMarkDelete_RGV.MaximumSize = new Size(29, 22);
            buttonUnMarkDelete_RGV.Name = "buttonUnMarkDelete_RGV";
            buttonUnMarkDelete_RGV.Size = new Size(29, 22);
            buttonUnMarkDelete_RGV.TabIndex = 4;
            toolTipInfo_RGV.SetToolTip(buttonUnMarkDelete_RGV, "Убрать пометку с ряда");
            buttonUnMarkDelete_RGV.UseVisualStyleBackColor = false;
            buttonUnMarkDelete_RGV.Visible = false;
            buttonUnMarkDelete_RGV.Click += buttonUnMarkDelete_RGV_Click;
            buttonUnMarkDelete_RGV.MouseEnter += buttonUnMarkDelete_RGV_MouseEnter;
            // 
            // buttonMarkDelete_RGV
            // 
            buttonMarkDelete_RGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMarkDelete_RGV.AutoSize = true;
            buttonMarkDelete_RGV.BackColor = SystemColors.ActiveCaption;
            buttonMarkDelete_RGV.BackgroundImage = Properties.Resources.icons8_stop_32;
            buttonMarkDelete_RGV.Enabled = false;
            buttonMarkDelete_RGV.Location = new Point(135, 0);
            buttonMarkDelete_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonMarkDelete_RGV.MaximumSize = new Size(29, 22);
            buttonMarkDelete_RGV.Name = "buttonMarkDelete_RGV";
            buttonMarkDelete_RGV.Size = new Size(29, 22);
            buttonMarkDelete_RGV.TabIndex = 4;
            toolTipInfo_RGV.SetToolTip(buttonMarkDelete_RGV, "Пометить ряд на удаление");
            buttonMarkDelete_RGV.UseVisualStyleBackColor = false;
            buttonMarkDelete_RGV.Visible = false;
            buttonMarkDelete_RGV.Click += buttonMarkDelete_RGV_Click;
            buttonMarkDelete_RGV.MouseEnter += buttonMarkDelete_RGV_MouseEnter;
            // 
            // buttonAdd_RGV
            // 
            buttonAdd_RGV.Anchor = AnchorStyles.Left;
            buttonAdd_RGV.AutoSize = true;
            buttonAdd_RGV.BackColor = SystemColors.ActiveCaption;
            buttonAdd_RGV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdd_RGV.Enabled = false;
            buttonAdd_RGV.Image = Properties.Resources.icons8_add_32;
            buttonAdd_RGV.Location = new Point(25, 27);
            buttonAdd_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonAdd_RGV.MaximumSize = new Size(88, 75);
            buttonAdd_RGV.Name = "buttonAdd_RGV";
            buttonAdd_RGV.Size = new Size(69, 64);
            buttonAdd_RGV.TabIndex = 1;
            toolTipInfo_RGV.SetToolTip(buttonAdd_RGV, "Добавить ряд в таблицу");
            buttonAdd_RGV.UseMnemonic = false;
            buttonAdd_RGV.UseVisualStyleBackColor = false;
            buttonAdd_RGV.Click += buttonAdd_RGV_Click;
            buttonAdd_RGV.MouseEnter += buttonAdd_RGV_MouseEnter;
            // 
            // buttonRemove_RGV
            // 
            buttonRemove_RGV.Anchor = AnchorStyles.Right;
            buttonRemove_RGV.AutoSize = true;
            buttonRemove_RGV.BackColor = SystemColors.ActiveCaption;
            buttonRemove_RGV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRemove_RGV.Enabled = false;
            buttonRemove_RGV.Image = Properties.Resources.icons8_delete_30;
            buttonRemove_RGV.Location = new Point(135, 26);
            buttonRemove_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonRemove_RGV.MaximumSize = new Size(88, 75);
            buttonRemove_RGV.Name = "buttonRemove_RGV";
            buttonRemove_RGV.Size = new Size(69, 65);
            buttonRemove_RGV.TabIndex = 2;
            toolTipInfo_RGV.SetToolTip(buttonRemove_RGV, "Включить режим удаления");
            buttonRemove_RGV.UseVisualStyleBackColor = false;
            buttonRemove_RGV.Click += buttonRemove_RGV_Click;
            buttonRemove_RGV.MouseEnter += buttonRemove_RGV_MouseEnter;
            // 
            // groupBoxFileActions_RGV
            // 
            groupBoxFileActions_RGV.Controls.Add(buttonLoad_RGV);
            groupBoxFileActions_RGV.Controls.Add(buttonSave_RGV);
            groupBoxFileActions_RGV.Location = new Point(19, 97);
            groupBoxFileActions_RGV.Margin = new Padding(3, 2, 3, 2);
            groupBoxFileActions_RGV.Name = "groupBoxFileActions_RGV";
            groupBoxFileActions_RGV.Padding = new Padding(3, 2, 3, 2);
            groupBoxFileActions_RGV.Size = new Size(228, 107);
            groupBoxFileActions_RGV.TabIndex = 6;
            groupBoxFileActions_RGV.TabStop = false;
            groupBoxFileActions_RGV.Text = "Работа с файлами";
            // 
            // buttonLoad_RGV
            // 
            buttonLoad_RGV.Anchor = AnchorStyles.Left;
            buttonLoad_RGV.AutoSize = true;
            buttonLoad_RGV.BackColor = SystemColors.ActiveCaption;
            buttonLoad_RGV.BackgroundImageLayout = ImageLayout.None;
            buttonLoad_RGV.Image = Properties.Resources.icons8_folder_32;
            buttonLoad_RGV.Location = new Point(25, 27);
            buttonLoad_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonLoad_RGV.MaximumSize = new Size(88, 75);
            buttonLoad_RGV.Name = "buttonLoad_RGV";
            buttonLoad_RGV.Size = new Size(69, 63);
            buttonLoad_RGV.TabIndex = 0;
            toolTipInfo_RGV.SetToolTip(buttonLoad_RGV, "Загрузить файл в таблицу");
            buttonLoad_RGV.UseVisualStyleBackColor = false;
            buttonLoad_RGV.Click += buttonLoad_RGV_Click;
            buttonLoad_RGV.MouseEnter += buttonLoad_RGV_MouseEnter;
            // 
            // buttonSave_RGV
            // 
            buttonSave_RGV.Anchor = AnchorStyles.Right;
            buttonSave_RGV.AutoSize = true;
            buttonSave_RGV.BackColor = SystemColors.ActiveCaption;
            buttonSave_RGV.BackgroundImageLayout = ImageLayout.Center;
            buttonSave_RGV.Enabled = false;
            buttonSave_RGV.Image = Properties.Resources.icons8_save_32;
            buttonSave_RGV.Location = new Point(135, 27);
            buttonSave_RGV.Margin = new Padding(3, 2, 3, 2);
            buttonSave_RGV.MaximumSize = new Size(88, 75);
            buttonSave_RGV.Name = "buttonSave_RGV";
            buttonSave_RGV.Size = new Size(69, 63);
            buttonSave_RGV.TabIndex = 3;
            toolTipInfo_RGV.SetToolTip(buttonSave_RGV, "Сохранить измененную таблицу в файл");
            buttonSave_RGV.UseVisualStyleBackColor = false;
            buttonSave_RGV.Click += buttonSave_RGV_Click;
            buttonSave_RGV.MouseEnter += buttonSave_RGV_MouseEnter;
            // 
            // toolTipInfo_RGV
            // 
            toolTipInfo_RGV.IsBalloon = true;
            toolTipInfo_RGV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogProject_RGV
            // 
            openFileDialogProject_RGV.FileName = "openFileDialog1";
            openFileDialogProject_RGV.FileOk += openFileDialogProject_RGV_FileOk;
            // 
            // driverNo_RGV
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            driverNo_RGV.DefaultCellStyle = dataGridViewCellStyle1;
            driverNo_RGV.FillWeight = 40F;
            driverNo_RGV.HeaderText = "№";
            driverNo_RGV.MinimumWidth = 6;
            driverNo_RGV.Name = "driverNo_RGV";
            driverNo_RGV.ReadOnly = true;
            driverNo_RGV.Width = 30;
            // 
            // autoNumber_RGV
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoNumber_RGV.DefaultCellStyle = dataGridViewCellStyle2;
            autoNumber_RGV.HeaderText = "Знаки";
            autoNumber_RGV.MaxInputLength = 6;
            autoNumber_RGV.MinimumWidth = 6;
            autoNumber_RGV.Name = "autoNumber_RGV";
            autoNumber_RGV.ReadOnly = true;
            autoNumber_RGV.Width = 80;
            // 
            // autoMark_RGV
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoMark_RGV.DefaultCellStyle = dataGridViewCellStyle3;
            autoMark_RGV.HeaderText = "Марка";
            autoMark_RGV.MinimumWidth = 6;
            autoMark_RGV.Name = "autoMark_RGV";
            autoMark_RGV.ReadOnly = true;
            autoMark_RGV.Width = 90;
            // 
            // technicalCondition_RGV
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            technicalCondition_RGV.DefaultCellStyle = dataGridViewCellStyle4;
            technicalCondition_RGV.HeaderText = "Тех. состояние";
            technicalCondition_RGV.MinimumWidth = 6;
            technicalCondition_RGV.Name = "technicalCondition_RGV";
            technicalCondition_RGV.ReadOnly = true;
            technicalCondition_RGV.Resizable = DataGridViewTriState.True;
            technicalCondition_RGV.Width = 125;
            // 
            // autoLocation_RGV
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoLocation_RGV.DefaultCellStyle = dataGridViewCellStyle5;
            autoLocation_RGV.HeaderText = "Место";
            autoLocation_RGV.MinimumWidth = 6;
            autoLocation_RGV.Name = "autoLocation_RGV";
            autoLocation_RGV.ReadOnly = true;
            autoLocation_RGV.Width = 110;
            // 
            // autoSpeed_RGV
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            autoSpeed_RGV.DefaultCellStyle = dataGridViewCellStyle6;
            autoSpeed_RGV.HeaderText = "Cкорость(Км\\ч)";
            autoSpeed_RGV.MaxInputLength = 3;
            autoSpeed_RGV.MinimumWidth = 6;
            autoSpeed_RGV.Name = "autoSpeed_RGV";
            autoSpeed_RGV.ReadOnly = true;
            autoSpeed_RGV.Width = 120;
            // 
            // autoCarrying_RGV
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoCarrying_RGV.DefaultCellStyle = dataGridViewCellStyle7;
            autoCarrying_RGV.HeaderText = "Грузоподъем(т)";
            autoCarrying_RGV.MaxInputLength = 4;
            autoCarrying_RGV.MinimumWidth = 6;
            autoCarrying_RGV.Name = "autoCarrying_RGV";
            autoCarrying_RGV.ReadOnly = true;
            autoCarrying_RGV.Width = 120;
            // 
            // autoFuel_RGV
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            autoFuel_RGV.DefaultCellStyle = dataGridViewCellStyle8;
            autoFuel_RGV.HeaderText = "Средний расход топлива(л\\100км)";
            autoFuel_RGV.MaxInputLength = 5;
            autoFuel_RGV.MinimumWidth = 6;
            autoFuel_RGV.Name = "autoFuel_RGV";
            autoFuel_RGV.ReadOnly = true;
            autoFuel_RGV.Width = 120;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1144, 381);
            Controls.Add(splitContainerTask_RGV);
            Controls.Add(menuStripTools_RGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripTools_RGV;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1160, 420);
            Name = "FormMain";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автотранспорт";
            Load += FormMain_Load;
            menuStripTools_RGV.ResumeLayout(false);
            menuStripTools_RGV.PerformLayout();
            splitContainerTask_RGV.Panel1.ResumeLayout(false);
            splitContainerTask_RGV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTask_RGV).EndInit();
            splitContainerTask_RGV.ResumeLayout(false);
            groupBoxData_RGV.ResumeLayout(false);
            tabControlData_RGV.ResumeLayout(false);
            autoTab_RGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuto_RGV).EndInit();
            changedAutoTab_RGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChanged_RGV).EndInit();
            tabControlSearch_RGV.ResumeLayout(false);
            driverNumSearch_RGV.ResumeLayout(false);
            driverNumSearch_RGV.PerformLayout();
            autoNumbersSearch_RGV.ResumeLayout(false);
            autoNumbersSearch_RGV.PerformLayout();
            groupBoxDataGrids_RGV.ResumeLayout(false);
            groupBoxDataGrids_RGV.PerformLayout();
            groupBoxFileActions_RGV.ResumeLayout(false);
            groupBoxFileActions_RGV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTools_RGV;
        private SplitContainer splitContainerTask_RGV;
        private ToolStripMenuItem helpToolStripMenuItem_RGV;
        private ToolStripMenuItem programToolStripMenuItem_RGV;
        private ToolStripMenuItem statsToolStripMenuItem_RGV;
        private ToolStripSeparator toolStripSeparator_RGV;
        private ToolStripMenuItem exitToolStripMenuItem_RGV;
        private ToolStripMenuItem infoToolStripMenuItem_RGV;
        private ToolStripMenuItem guideToolStripMenuItem_RGV;
        private ToolTip toolTipInfo_RGV;
        private SaveFileDialog saveFileDialogInfo_RGV;
        private OpenFileDialog openFileDialogProject_RGV;
        private ToolStripMenuItem filterToolStripMenuItem_RGV;
        private ToolStripMenuItem redRowsToolStripMenuItem_RGV;
        private ToolStripMenuItem aquaRowsToolStripMenuItem_RGV;
        private GroupBox groupBoxData_RGV;
        private TabControl tabControlData_RGV;
        private TabPage autoTab_RGV;
        private TabPage changedAutoTab_RGV;
        private DataGridView dataGridViewAuto_RGV;
        public DataGridView dataGridViewChanged_RGV;
        private DataGridViewTextBoxColumn driverNoChanged_RGV;
        private DataGridViewTextBoxColumn autoNumberChanged_RGV;
        private DataGridViewTextBoxColumn autoMarkChanged_RGV;
        private DataGridViewTextBoxColumn technicalConditionChanged_RGV;
        private DataGridViewTextBoxColumn autoLocationnChanged_RGV;
        private DataGridViewTextBoxColumn autoSpeedChanged_RGV;
        private DataGridViewTextBoxColumn autoCarryingChanged_RGV;
        private DataGridViewTextBoxColumn autoFuelChanged_RGV;
        private GroupBox groupBoxDataGrids_RGV;
        private Button buttonRemove_RGV;
        private Button buttonUnMarkDelete_RGV;
        private Button buttonMarkDelete_RGV;
        private Button buttonTrueDelete_RGV;
        private Button buttonAdd_RGV;
        private TabControl tabControlSearch_RGV;
        private TabPage driverNumSearch_RGV;
        private Button buttonSearchDriverNum_RGV;
        private TextBox textBoxSearchDriverNum_RGV;
        private TabPage autoNumbersSearch_RGV;
        private Button buttonSearchAutoNum_RGV;
        private TextBox textBoxAutoNumSearch_RGV;
        private GroupBox groupBoxFileActions_RGV;
        private Button buttonLoad_RGV;
        private Button buttonSave_RGV;
        private DataGridViewTextBoxColumn driverNo_RGV;
        private DataGridViewTextBoxColumn autoNumber_RGV;
        private DataGridViewTextBoxColumn autoMark_RGV;
        private DataGridViewTextBoxColumn technicalCondition_RGV;
        private DataGridViewTextBoxColumn autoLocation_RGV;
        private DataGridViewTextBoxColumn autoSpeed_RGV;
        private DataGridViewTextBoxColumn autoCarrying_RGV;
        private DataGridViewTextBoxColumn autoFuel_RGV;
    }
}
