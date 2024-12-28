using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Tyuiu.RubankoGV.Sprint7.V8;
using Tyuiu.RubankoGV.Sprint7.V8.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.RubankoGV.Sprint7.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogProject_RGV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogInfo_RGV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        //Общая функция поиска
        public void Search(DataGridView dataGrid, string searchValue, int searchableValue)
        {
            dataGrid.ClearSelection();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[searchableValue].Value.ToString().ToUpper() == searchValue)
                {
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Selected = true;
                    }
                }
            }
        }
        //Общее сокрытие рядов
        public void InvisibleRowsByColors(DataGridView dataGrid, Color color, bool rowVisibility)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Style.BackColor == color)
                {
                    row.Visible = rowVisibility;
                }
            }
        }
        DataService ds = new DataService();
        public string? openFilePath;
        public bool fileOpened = false;
        AutoCompleteStringCollection driverNumComplete = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoNumComplete = new AutoCompleteStringCollection();

        //Содержит прошлые значения ячеек(до редактирования)
        public int cellInt = 0;
        public string? cellString = String.Empty;
        private void infoToolStripMenuItem_RGV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_RGV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statsToolStripMenuItem_RGV_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics(dataGridViewChanged_RGV);
            formStatistics.ShowDialog();
        }

        private void guideToolStripMenuItem_RGV_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        //Загрузка файла в таблицы, активация кнопок
        private void buttonLoad_RGV_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialogProject_RGV.ShowDialog();
                openFilePath = openFileDialogProject_RGV.FileName;
                List<string[]> gridInfo = ds.LoadDataFromFile(openFilePath);
                this.dataGridViewAuto_RGV.Rows.Clear();
                this.dataGridViewAuto_RGV.RowCount = gridInfo.Count;
                this.dataGridViewChanged_RGV.Rows.Clear();
                this.dataGridViewChanged_RGV.RowCount = gridInfo.Count;
                this.dataGridViewAuto_RGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridViewChanged_RGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int i = 0; i < gridInfo.Count; i++)
                {
                    for (int j = 0; j < gridInfo[0].Length; j++)
                    {
                        if (j == 0 || j > 4)
                        {
                            this.dataGridViewAuto_RGV.Rows[i].Cells[j].Value = Convert.ToInt32(gridInfo[i][j]);
                            this.dataGridViewChanged_RGV.Rows[i].Cells[j].Value = Convert.ToInt32(gridInfo[i][j]);
                            //Для забивания типов данных столбцов(Понадобится больше)
                            this.dataGridViewAuto_RGV.Columns[j].ValueType = typeof(int);
                            this.dataGridViewChanged_RGV.Columns[j].ValueType = typeof(int);

                        }
                        else
                        {
                            this.dataGridViewAuto_RGV.Rows[i].Cells[j].Value = gridInfo[i][j].ToString().ToUpper();
                            this.dataGridViewChanged_RGV.Rows[i].Cells[j].Value = gridInfo[i][j].ToString().ToUpper();
                            this.dataGridViewAuto_RGV.Columns[j].ValueType = typeof(string);
                            this.dataGridViewChanged_RGV.Columns[j].ValueType = typeof(string);
                        }
                    }
                }

                for (int i = 0; i < dataGridViewAuto_RGV.RowCount; i++)
                {
                    driverNumComplete.Add(this.dataGridViewAuto_RGV.Rows[i].Cells[0].Value.ToString());
                    autoNumComplete.Add(this.dataGridViewAuto_RGV.Rows[i].Cells[1].Value.ToString());
                }
                this.textBoxSearchDriverNum_RGV.AutoCompleteCustomSource = driverNumComplete;
                this.textBoxSearchDriverNum_RGV.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxSearchDriverNum_RGV.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBoxAutoNumSearch_RGV.AutoCompleteCustomSource = autoNumComplete;
                this.textBoxAutoNumSearch_RGV.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxAutoNumSearch_RGV.AutoCompleteSource = AutoCompleteSource.CustomSource;
                fileOpened = true;
                this.buttonSave_RGV.Enabled = true;
                this.statsToolStripMenuItem_RGV.Enabled = true;
                this.tabControlSearch_RGV.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }
        //Поиск в зависимости от выбранной таблицы
        private void buttonSearchDriverNum_RGV_Click(object sender, EventArgs e)
        {
            //if (this.dataGridViewChanged_RGV.Rows[0].Cells[1].ValueType == typeof(string))
            //{
            //    MessageBox.Show("Это ???");
            //}
            this.textBoxAutoNumSearch_RGV.AutoCompleteMode = AutoCompleteMode.Suggest;
            string searchValue = this.textBoxSearchDriverNum_RGV.Text;
            try
            {
                switch (this.tabControlData_RGV
                    .SelectedIndex)
                {
                    case 0:
                        Search(this.dataGridViewAuto_RGV, searchValue, 0);
                        break;
                    case 1:
                        Search(this.dataGridViewChanged_RGV, searchValue, 0);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Данный ряд скрыт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchAutoNum_RGV_Click(object sender, EventArgs e)
        {
            string searchValue = this.textBoxAutoNumSearch_RGV.Text;
            try
            {
                switch (this.tabControlData_RGV
                    .SelectedIndex)
                {
                    case 0:
                        Search(this.dataGridViewAuto_RGV, searchValue, 1);
                        break;
                    case 1:
                        Search(this.dataGridViewChanged_RGV, searchValue, 1);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Данный ряд скрыт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_RGV_Click(object sender, EventArgs e)
        {
            //Сохранение файла(без помеченных строк)
            this.saveFileDialogInfo_RGV.FileName = "OutPutAuto.csv";
    this.saveFileDialogInfo_RGV.InitialDirectory = @"C:\DataSprint7";
    this.saveFileDialogInfo_RGV.Filter = "CSV Files (*.csv)|*.csv";
    this.saveFileDialogInfo_RGV.Title = "Save CSV File";

    // Отображение диалогового окна и проверка, выбрал ли пользователь файл
    if (this.saveFileDialogInfo_RGV.ShowDialog() == DialogResult.OK)
    {
            // Получение пути к выбранному файлу
            string path = this.saveFileDialogInfo_RGV.FileName;

            // Удаление файла, если он существует
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // Получение данных из DataGridView
            int rowCount = this.dataGridViewChanged_RGV.RowCount;
            int columnCount = this.dataGridViewChanged_RGV.ColumnCount;
            string str = "";

            // Создание строки CSV
            for (int i = 0; i < rowCount - 1; i++) // -1, чтобы исключить пустую строку в конце
            {
                for (int j = 0; j < columnCount; j++)
                {
                    str += this.dataGridViewChanged_RGV.Rows[i].Cells[j].Value.ToString();
                    if (j < columnCount - 1)
                    {
                        str += ",";
                    }
                }
                str += "\n";
            }

            // Сохранение данных в файл
            File.WriteAllText(path, str);

            MessageBox.Show("Файл сохранен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Задание максимальной длины элементов в столбцах
            ((DataGridViewTextBoxColumn)dataGridViewChanged_RGV.Columns[1]).MaxInputLength = 6;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_RGV.Columns[2]).MaxInputLength = 20;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_RGV.Columns[3]).MaxInputLength = 30;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_RGV.Columns[4]).MaxInputLength = 30;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_RGV.Columns[5]).MaxInputLength = 5;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_RGV.Columns[6]).MaxInputLength = 5;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_RGV.Columns[7]).MaxInputLength = 5;



            this.BeginInvoke(new Action(() =>
            {
                buttonLoad_RGV.Focus();
            }));
        }
        //Проверяет значение с тем, что было раньше и не отмечает ячейку если они сходятся
        //Также проверяет, чтобы ячейки не были пустыми
        private void dataGridViewChanged_RGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isInt = cellInt != 0;
            bool isString = !isInt;
            try
            {
                if (!String.IsNullOrEmpty(this.dataGridViewChanged_RGV.CurrentCell.Value.ToString()) && !Convert.IsDBNull(this.dataGridViewChanged_RGV.CurrentCell.Value) && this.dataGridViewChanged_RGV.CurrentCell.Style.BackColor != Color.Aqua)
                {
                    if ((isInt && Convert.ToInt32(this.dataGridViewChanged_RGV.CurrentCell.Value) != cellInt) || (isString && this.dataGridViewChanged_RGV.CurrentCell.Value.ToString() != cellString))
                    {
                        this.dataGridViewChanged_RGV.CurrentCell.Style.BackColor = Color.Green;
                        if (e.ColumnIndex == 0)
                        {
                            driverNumComplete.Remove(cellInt.ToString());
                            driverNumComplete.Add(this.dataGridViewChanged_RGV.CurrentCell.Value.ToString());
                        }
                        if (e.ColumnIndex == 1)
                        {
                            autoNumComplete.Remove(cellString);
                            autoNumComplete.Add(this.dataGridViewChanged_RGV.CurrentCell.Value.ToString());
                        }
                    }
                }

            }
            catch (NullReferenceException)
            {
                this.dataGridViewChanged_RGV.CurrentCell.Value = cellString;
                cellString = string.Empty;
            }
            finally
            {
                if (Convert.IsDBNull(this.dataGridViewChanged_RGV.CurrentCell.Value))
                {
                    if (cellInt != 0)
                    {
                        this.dataGridViewChanged_RGV.CurrentCell.Value = cellInt;
                        cellInt = 0;
                    }
                }
            }

        }



        private void NumInput(object? sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void StringInput(object? sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '-' || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        //Ограничение на ввод некоторых символов в зависимости от типа ячейки
        private void dataGridViewChanged_RGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            bool isCellString = (this.dataGridViewChanged_RGV.CurrentCell.ValueType == typeof(string));
            bool isAutoNum = (this.dataGridViewChanged_RGV.CurrentCell.ColumnIndex == 1);
            if (e.Control is DataGridViewTextBoxEditingControl textBoxEditingControl)
            {
                textBoxEditingControl.KeyPress -= NumInput;
                textBoxEditingControl.KeyPress -= StringInput;
                if (isCellString && !isAutoNum)
                {
                    textBoxEditingControl.KeyPress += StringInput;
                }
                else if (!isCellString && !isAutoNum)
                {
                    textBoxEditingControl.KeyPress += NumInput;
                }

            }
        }
        //Выключение кнопок при переходе на первую таблмцу
        private void tabControlData_RGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlData_RGV.SelectedIndex == 1 && fileOpened)
            {
                this.buttonAdd_RGV.Enabled = true;
                this.buttonRemove_RGV.Enabled = true;

            }
            else
            {
                this.buttonAdd_RGV.Enabled = false;
                this.buttonRemove_RGV.Enabled = false;
                this.buttonMarkDelete_RGV.Enabled = false;
                this.buttonMarkDelete_RGV.Visible = false;
                this.buttonUnMarkDelete_RGV.Enabled = false;
                this.buttonUnMarkDelete_RGV.Visible = false;
                this.buttonTrueDelete_RGV.Enabled = false;
                this.buttonTrueDelete_RGV.Visible = false;
                this.dataGridViewChanged_RGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        #region ToolTipChange
        private void buttonTrueDelete_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Удалить";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonAdd_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Добавить";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonSave_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Сохранить";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonLoad_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Загрузить";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;

        }
        private void buttonRemove_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Удалить";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonSearchDriverNum_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Поиск";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonSearchAutoNum_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Поиск";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonMarkDelete_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Удалить";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonUnMarkDelete_RGV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_RGV.ToolTipTitle = "Убрать из удаленных";
            toolTipInfo_RGV.ToolTipIcon = ToolTipIcon.Info;
        }
        #endregion


        private void buttonRemove_RGV_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewChanged_RGV.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
                this.dataGridViewChanged_RGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
                this.buttonMarkDelete_RGV.Enabled = false;
                this.buttonMarkDelete_RGV.Visible = false;
                this.buttonUnMarkDelete_RGV.Enabled = false;
                this.buttonUnMarkDelete_RGV.Visible = false;
                this.buttonTrueDelete_RGV.Enabled = false;
                this.buttonTrueDelete_RGV.Visible = false;
            }
            else
            {
                this.dataGridViewChanged_RGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.buttonMarkDelete_RGV.Enabled = true;
                this.buttonMarkDelete_RGV.Visible = true;
                this.buttonUnMarkDelete_RGV.Enabled = true;
                this.buttonUnMarkDelete_RGV.Visible = true;
                this.buttonTrueDelete_RGV.Enabled = true;
                this.buttonTrueDelete_RGV.Visible = true;
            }


        }
        //Покраска выделенных ячеек на удаление
        private void buttonMarkDelete_RGV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_RGV.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.OrangeRed;
                }
            }
        }
        //Убирание покраски удаления
        private void buttonUnMarkDelete_RGV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_RGV.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.OrangeRed)
                    {
                        cell.Style.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                    }
                }
            }
        }
        //Сохраняет предыдущие значения
        private void dataGridViewChanged_RGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellInt = this.dataGridViewChanged_RGV.CurrentCell.ValueType == typeof(int) ? Convert.ToInt32(this.dataGridViewChanged_RGV.CurrentCell.Value) : 0;
            cellString = this.dataGridViewChanged_RGV.CurrentCell.ValueType == typeof(string) ? this.dataGridViewChanged_RGV.CurrentCell.Value.ToString() : String.Empty;
        }
        //Покраска новых строк
        private void buttonAdd_RGV_Click(object sender, EventArgs e)
        {
            this.dataGridViewChanged_RGV.Rows.Add(0, "######", "НЕИЗВЕСТНО", "НЕИЗВЕСТНО", "НЕИЗВЕСТНО", 0, 0, 0);
            foreach (DataGridViewCell cell in this.dataGridViewChanged_RGV.Rows[^1].Cells)
            {
                cell.Style.BackColor = Color.Aqua;
            }
        }
        //Фильтры
        private void redRowsToolStripMenuItem_RGV_Click(object sender, EventArgs e)
        {

            if (!this.redRowsToolStripMenuItem_RGV.Checked)
            {
                this.redRowsToolStripMenuItem_RGV.Checked = true;
                InvisibleRowsByColors(this.dataGridViewChanged_RGV, Color.OrangeRed, true);
            }
            else
            {
                this.redRowsToolStripMenuItem_RGV.Checked = false;
                InvisibleRowsByColors(this.dataGridViewChanged_RGV, Color.OrangeRed, false);
            }
        }

        private void aquaRowsToolStripMenuItem_RGV_Click(object sender, EventArgs e)
        {
            if (!this.aquaRowsToolStripMenuItem_RGV.Checked)
            {
                this.aquaRowsToolStripMenuItem_RGV.Checked = true;
                InvisibleRowsByColors(this.dataGridViewChanged_RGV, Color.Aqua, true);
            }
            else
            {
                this.aquaRowsToolStripMenuItem_RGV.Checked = false;
                InvisibleRowsByColors(this.dataGridViewChanged_RGV, Color.Aqua, false);
            }
        }

        private void filterToolStripMenuItem_RGV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_RGV.Rows)
            {
                if (row.Cells[0].Style.BackColor == Color.OrangeRed)
                {
                    this.redRowsToolStripMenuItem_RGV.Enabled = true;
                }
                if (row.Cells[0].Style.BackColor == Color.Aqua)
                {
                    this.aquaRowsToolStripMenuItem_RGV.Enabled = true;
                }
            }
        }
        //Окончательное удаление строк(и)
        private void buttonTrueDelete_RGV_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить данный ряд?", "Да", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewChanged_RGV.SelectedRows)
                {
                    this.dataGridViewChanged_RGV.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void dataGridViewAuto_RGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxData_RGV_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainerTask_RGV_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialogProject_RGV_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dataGridViewChanged_RGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
