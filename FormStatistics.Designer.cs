using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Tyuiu.RubankoGV.Sprint7.V8
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            splitContainer_RGV = new SplitContainer();
            groupBoxGrid_RGV = new GroupBox();
            labelAquaRowCount_RGV = new Label();
            labelRedRowsCount_RGV = new Label();
            groupBoxAuto_RGV = new GroupBox();
            labelPopularMark_RGV = new Label();
            labelPopularLocation_RGV = new Label();
            labelAutoCondition_RGV = new Label();
            labelAutoCount_RGV = new Label();
            groupBoxAutoStats_RGV = new GroupBox();
            labelMaxFuel_RGV = new Label();
            labelMinLoad_RGV = new Label();
            labelAvgLoad_RGV = new Label();
            labelMinFuel_RGV = new Label();
            labelAvgSpeed_RGV = new Label();
            labelMinSpeed_RGV = new Label();
            labelAvgFuel_RGV = new Label();
            labelMaxLoad_RGV = new Label();
            labelMaxSpeed_RGV = new Label();
            groupBoxDrivers_RGV = new GroupBox();
            labelDriverCount_RGV = new Label();
            chartMarkToSpeed_RGV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelRichDriver_RGV = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer_RGV).BeginInit();
            splitContainer_RGV.Panel1.SuspendLayout();
            splitContainer_RGV.Panel2.SuspendLayout();
            splitContainer_RGV.SuspendLayout();
            groupBoxGrid_RGV.SuspendLayout();
            groupBoxAuto_RGV.SuspendLayout();
            groupBoxAutoStats_RGV.SuspendLayout();
            groupBoxDrivers_RGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMarkToSpeed_RGV).BeginInit();
            SuspendLayout();
            // 
            // splitContainer_RGV
            // 
            splitContainer_RGV.Dock = DockStyle.Fill;
            splitContainer_RGV.Location = new Point(0, 0);
            splitContainer_RGV.Margin = new Padding(3, 2, 3, 2);
            splitContainer_RGV.Name = "splitContainer_RGV";
            // 
            // splitContainer_RGV.Panel1
            // 
            splitContainer_RGV.Panel1.Controls.Add(groupBoxGrid_RGV);
            splitContainer_RGV.Panel1.Controls.Add(groupBoxAuto_RGV);
            splitContainer_RGV.Panel1.Controls.Add(groupBoxAutoStats_RGV);
            splitContainer_RGV.Panel1.Controls.Add(groupBoxDrivers_RGV);
            // 
            // splitContainer_RGV.Panel2
            // 
            splitContainer_RGV.Panel2.Controls.Add(chartMarkToSpeed_RGV);
            splitContainer_RGV.Size = new Size(935, 338);
            splitContainer_RGV.SplitterDistance = 581;
            splitContainer_RGV.TabIndex = 1;
            // 
            // groupBoxGrid_RGV
            // 
            groupBoxGrid_RGV.Controls.Add(labelAquaRowCount_RGV);
            groupBoxGrid_RGV.Controls.Add(labelRedRowsCount_RGV);
            groupBoxGrid_RGV.Font = new System.Drawing.Font("Times New Roman", 10F);
            groupBoxGrid_RGV.Location = new Point(318, 107);
            groupBoxGrid_RGV.Margin = new Padding(3, 2, 3, 2);
            groupBoxGrid_RGV.Name = "groupBoxGrid_RGV";
            groupBoxGrid_RGV.Padding = new Padding(3, 2, 3, 2);
            groupBoxGrid_RGV.Size = new Size(261, 213);
            groupBoxGrid_RGV.TabIndex = 0;
            groupBoxGrid_RGV.TabStop = false;
            groupBoxGrid_RGV.Text = "Таблица";
            // 
            // labelAquaRowCount_RGV
            // 
            labelAquaRowCount_RGV.AutoSize = true;
            labelAquaRowCount_RGV.Location = new Point(1, 74);
            labelAquaRowCount_RGV.Name = "labelAquaRowCount_RGV";
            labelAquaRowCount_RGV.Size = new Size(196, 16);
            labelAquaRowCount_RGV.TabIndex = 0;
            labelAquaRowCount_RGV.Text = "Количество добавленных строк:";
            // 
            // labelRedRowsCount_RGV
            // 
            labelRedRowsCount_RGV.AutoSize = true;
            labelRedRowsCount_RGV.Location = new Point(6, 38);
            labelRedRowsCount_RGV.Name = "labelRedRowsCount_RGV";
            labelRedRowsCount_RGV.Size = new Size(181, 16);
            labelRedRowsCount_RGV.TabIndex = 0;
            labelRedRowsCount_RGV.Text = "Количество удаленных строк:";
            // 
            // groupBoxAuto_RGV
            // 
            groupBoxAuto_RGV.Controls.Add(labelPopularMark_RGV);
            groupBoxAuto_RGV.Controls.Add(labelPopularLocation_RGV);
            groupBoxAuto_RGV.Controls.Add(labelAutoCondition_RGV);
            groupBoxAuto_RGV.Controls.Add(labelAutoCount_RGV);
            groupBoxAuto_RGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxAuto_RGV.Location = new Point(195, 9);
            groupBoxAuto_RGV.Margin = new Padding(3, 2, 3, 2);
            groupBoxAuto_RGV.Name = "groupBoxAuto_RGV";
            groupBoxAuto_RGV.Padding = new Padding(3, 2, 3, 2);
            groupBoxAuto_RGV.Size = new Size(384, 94);
            groupBoxAuto_RGV.TabIndex = 0;
            groupBoxAuto_RGV.TabStop = false;
            groupBoxAuto_RGV.Text = "Машины";
            // 
            // labelPopularMark_RGV
            // 
            labelPopularMark_RGV.AutoSize = true;
            labelPopularMark_RGV.Location = new Point(5, 24);
            labelPopularMark_RGV.Name = "labelPopularMark_RGV";
            labelPopularMark_RGV.Size = new Size(167, 17);
            labelPopularMark_RGV.TabIndex = 0;
            labelPopularMark_RGV.Text = "Самая популярная марка:";
            // 
            // labelPopularLocation_RGV
            // 
            labelPopularLocation_RGV.AutoSize = true;
            labelPopularLocation_RGV.Location = new Point(5, 54);
            labelPopularLocation_RGV.Name = "labelPopularLocation_RGV";
            labelPopularLocation_RGV.Size = new Size(167, 17);
            labelPopularLocation_RGV.TabIndex = 0;
            labelPopularLocation_RGV.Text = "Самое популярное место:";
            // 
            // labelAutoCondition_RGV
            // 
            labelAutoCondition_RGV.AutoSize = true;
            labelAutoCondition_RGV.Location = new Point(5, 39);
            labelAutoCondition_RGV.Name = "labelAutoCondition_RGV";
            labelAutoCondition_RGV.Size = new Size(214, 17);
            labelAutoCondition_RGV.TabIndex = 0;
            labelAutoCondition_RGV.Text = "Подавляющее состояние машин:";
            // 
            // labelAutoCount_RGV
            // 
            labelAutoCount_RGV.AutoSize = true;
            labelAutoCount_RGV.Location = new Point(5, 69);
            labelAutoCount_RGV.Name = "labelAutoCount_RGV";
            labelAutoCount_RGV.Size = new Size(169, 17);
            labelAutoCount_RGV.TabIndex = 0;
            labelAutoCount_RGV.Text = "Количество автомобилей:";
            // 
            // groupBoxAutoStats_RGV
            // 
            groupBoxAutoStats_RGV.Controls.Add(labelMaxFuel_RGV);
            groupBoxAutoStats_RGV.Controls.Add(labelMinLoad_RGV);
            groupBoxAutoStats_RGV.Controls.Add(labelAvgLoad_RGV);
            groupBoxAutoStats_RGV.Controls.Add(labelMinFuel_RGV);
            groupBoxAutoStats_RGV.Controls.Add(labelAvgSpeed_RGV);
            groupBoxAutoStats_RGV.Controls.Add(labelMinSpeed_RGV);
            groupBoxAutoStats_RGV.Controls.Add(labelAvgFuel_RGV);
            groupBoxAutoStats_RGV.Controls.Add(labelMaxLoad_RGV);
            groupBoxAutoStats_RGV.Controls.Add(labelMaxSpeed_RGV);
            groupBoxAutoStats_RGV.Font = new System.Drawing.Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxAutoStats_RGV.Location = new Point(10, 107);
            groupBoxAutoStats_RGV.Margin = new Padding(3, 2, 3, 2);
            groupBoxAutoStats_RGV.Name = "groupBoxAutoStats_RGV";
            groupBoxAutoStats_RGV.Padding = new Padding(3, 2, 3, 2);
            groupBoxAutoStats_RGV.Size = new Size(303, 213);
            groupBoxAutoStats_RGV.TabIndex = 0;
            groupBoxAutoStats_RGV.TabStop = false;
            groupBoxAutoStats_RGV.Text = "Характеристики машин";
            // 
            // labelMaxFuel_RGV
            // 
            labelMaxFuel_RGV.AutoSize = true;
            labelMaxFuel_RGV.Location = new Point(2, 187);
            labelMaxFuel_RGV.Name = "labelMaxFuel_RGV";
            labelMaxFuel_RGV.Size = new Size(165, 15);
            labelMaxFuel_RGV.TabIndex = 0;
            labelMaxFuel_RGV.Text = "Максимум расхода топлива:";
            // 
            // labelMinLoad_RGV
            // 
            labelMinLoad_RGV.AutoSize = true;
            labelMinLoad_RGV.Location = new Point(5, 97);
            labelMinLoad_RGV.Name = "labelMinLoad_RGV";
            labelMinLoad_RGV.Size = new Size(150, 15);
            labelMinLoad_RGV.TabIndex = 0;
            labelMinLoad_RGV.Text = "Минимум грузоподъема:";
            // 
            // labelAvgLoad_RGV
            // 
            labelAvgLoad_RGV.AutoSize = true;
            labelAvgLoad_RGV.Location = new Point(6, 112);
            labelAvgLoad_RGV.Name = "labelAvgLoad_RGV";
            labelAvgLoad_RGV.Size = new Size(134, 15);
            labelAvgLoad_RGV.TabIndex = 0;
            labelAvgLoad_RGV.Text = "Средний грузоподъем:";
            // 
            // labelMinFuel_RGV
            // 
            labelMinFuel_RGV.AutoSize = true;
            labelMinFuel_RGV.Location = new Point(5, 161);
            labelMinFuel_RGV.Name = "labelMinFuel_RGV";
            labelMinFuel_RGV.Size = new Size(161, 15);
            labelMinFuel_RGV.TabIndex = 0;
            labelMinFuel_RGV.Text = "Минимум расхода топлива:";
            // 
            // labelAvgSpeed_RGV
            // 
            labelAvgSpeed_RGV.AutoSize = true;
            labelAvgSpeed_RGV.Location = new Point(5, 38);
            labelAvgSpeed_RGV.Name = "labelAvgSpeed_RGV";
            labelAvgSpeed_RGV.Size = new Size(108, 15);
            labelAvgSpeed_RGV.TabIndex = 0;
            labelAvgSpeed_RGV.Text = "Средняя скорость:";
            // 
            // labelMinSpeed_RGV
            // 
            labelMinSpeed_RGV.AutoSize = true;
            labelMinSpeed_RGV.Location = new Point(5, 17);
            labelMinSpeed_RGV.Name = "labelMinSpeed_RGV";
            labelMinSpeed_RGV.Size = new Size(141, 15);
            labelMinSpeed_RGV.TabIndex = 0;
            labelMinSpeed_RGV.Text = "Минимальная скорость:";
            // 
            // labelAvgFuel_RGV
            // 
            labelAvgFuel_RGV.AutoSize = true;
            labelAvgFuel_RGV.Location = new Point(5, 75);
            labelAvgFuel_RGV.Name = "labelAvgFuel_RGV";
            labelAvgFuel_RGV.Size = new Size(145, 15);
            labelAvgFuel_RGV.TabIndex = 0;
            labelAvgFuel_RGV.Text = "Средний расход топлива:";
            // 
            // labelMaxLoad_RGV
            // 
            labelMaxLoad_RGV.AutoSize = true;
            labelMaxLoad_RGV.Location = new Point(6, 136);
            labelMaxLoad_RGV.Name = "labelMaxLoad_RGV";
            labelMaxLoad_RGV.Size = new Size(154, 15);
            labelMaxLoad_RGV.TabIndex = 0;
            labelMaxLoad_RGV.Text = "Максимум грузоподъема:";
            // 
            // labelMaxSpeed_RGV
            // 
            labelMaxSpeed_RGV.AutoSize = true;
            labelMaxSpeed_RGV.Location = new Point(6, 60);
            labelMaxSpeed_RGV.Name = "labelMaxSpeed_RGV";
            labelMaxSpeed_RGV.Size = new Size(145, 15);
            labelMaxSpeed_RGV.TabIndex = 0;
            labelMaxSpeed_RGV.Text = "Максимальная скорость:";
            // 
            // groupBoxDrivers_RGV
            // 
            groupBoxDrivers_RGV.Controls.Add(labelDriverCount_RGV);
            groupBoxDrivers_RGV.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDrivers_RGV.Location = new Point(10, 9);
            groupBoxDrivers_RGV.Margin = new Padding(3, 2, 3, 2);
            groupBoxDrivers_RGV.Name = "groupBoxDrivers_RGV";
            groupBoxDrivers_RGV.Padding = new Padding(3, 2, 3, 2);
            groupBoxDrivers_RGV.Size = new Size(179, 94);
            groupBoxDrivers_RGV.TabIndex = 0;
            groupBoxDrivers_RGV.TabStop = false;
            groupBoxDrivers_RGV.Text = "Водители";
            // 
            // labelDriverCount_RGV
            // 
            labelDriverCount_RGV.AutoSize = true;
            labelDriverCount_RGV.Location = new Point(5, 26);
            labelDriverCount_RGV.Name = "labelDriverCount_RGV";
            labelDriverCount_RGV.Size = new Size(92, 19);
            labelDriverCount_RGV.TabIndex = 0;
            labelDriverCount_RGV.Text = "Количество:";
            // 
            // chartMarkToSpeed_RGV
            // 
            chartMarkToSpeed_RGV.BackColor = SystemColors.ActiveCaption;
            chartMarkToSpeed_RGV.BorderlineColor = SystemColors.GradientInactiveCaption;
            chartArea1.Name = "ChartArea1";
            chartMarkToSpeed_RGV.ChartAreas.Add(chartArea1);
            chartMarkToSpeed_RGV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMarkToSpeed_RGV.Legends.Add(legend1);
            chartMarkToSpeed_RGV.Location = new Point(0, 0);
            chartMarkToSpeed_RGV.Margin = new Padding(3, 2, 3, 2);
            chartMarkToSpeed_RGV.Name = "chartMarkToSpeed_RGV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartMarkToSpeed_RGV.Series.Add(series1);
            chartMarkToSpeed_RGV.Size = new Size(350, 338);
            chartMarkToSpeed_RGV.TabIndex = 0;
            title1.Name = "Соотношение марок и колчиества";
            chartMarkToSpeed_RGV.Titles.Add(title1);
            // 
            // labelRichDriver_RGV
            // 
            labelRichDriver_RGV.Location = new Point(0, 0);
            labelRichDriver_RGV.Name = "labelRichDriver_RGV";
            labelRichDriver_RGV.Size = new Size(100, 23);
            labelRichDriver_RGV.TabIndex = 0;
            labelRichDriver_RGV.Text = "Водители";
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(935, 338);
            Controls.Add(splitContainer_RGV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += FormStatistics_Load;
            splitContainer_RGV.Panel1.ResumeLayout(false);
            splitContainer_RGV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_RGV).EndInit();
            splitContainer_RGV.ResumeLayout(false);
            groupBoxGrid_RGV.ResumeLayout(false);
            groupBoxGrid_RGV.PerformLayout();
            groupBoxAuto_RGV.ResumeLayout(false);
            groupBoxAuto_RGV.PerformLayout();
            groupBoxAutoStats_RGV.ResumeLayout(false);
            groupBoxAutoStats_RGV.PerformLayout();
            groupBoxDrivers_RGV.ResumeLayout(false);
            groupBoxDrivers_RGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartMarkToSpeed_RGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer_RGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarkToSpeed_RGV;
        private GroupBox groupBoxGrid_RGV;
        private Label labelAquaRowCount_RGV;
        private Label labelRedRowsCount_RGV;
        private GroupBox groupBoxAuto_RGV;
        private Label labelPopularMark_RGV;
        private Label labelPopularLocation_RGV;
        private Label labelAutoCondition_RGV;
        private Label labelAutoCount_RGV;
        private GroupBox groupBoxAutoStats_RGV;
        private Label labelMaxFuel_RGV;
        private Label labelMinLoad_RGV;
        private Label labelAvgLoad_RGV;
        private Label labelMinFuel_RGV;
        private Label labelAvgSpeed_RGV;
        private Label labelMinSpeed_RGV;
        private Label labelAvgFuel_RGV;
        private Label labelMaxLoad_RGV;
        private Label labelMaxSpeed_RGV;
        private GroupBox groupBoxDrivers_RGV;
        private Label labelRichDriver_RGV;
        private Label labelDriverCount_RGV;
    }
}