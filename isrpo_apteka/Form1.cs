using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isrpo_apteka
{
    public partial class Form1 : Form
    {
        string category = "SELECT Name, Price FROM products ORDER BY Name ASC";
        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelName.Visible = false;
            labelPrice.Visible = false;
            labelDescription.Visible = false;
            labelForm.Visible = false;
            buttonAerozole.Visible = false;
            buttonHard.Visible = false;
            buttonLiquid.Visible = false;
            buttonSoft.Visible = false;

            listBoxCategory.Items.Add("Без категории");
            listBoxCategory.Items.Add("Антибактериальные препараты");
            listBoxCategory.Items.Add("Гормоны");
            listBoxCategory.Items.Add("Диагностические средства");
            listBoxCategory.Items.Add("Препараты, влияющие на иммунитет");
            listBoxCategory.Items.Add("Препараты влияющие на метаболизм");
            listBoxCategory.Items.Add("Препараты влияющие на психику");
            listBoxCategory.Items.Add("Препараты, влияющие на свертываемость крови");
            listBoxCategory.Items.Add("Препараты, влияющие на тонус сосудов");
            listBoxCategory.Items.Add("Препараты, влияющие на функцию бронхов");
            listBoxCategory.Items.Add("Препараты, влияющие на функции желудочно-кишечного тракта");
            listBoxCategory.Items.Add("Препараты, влияющие на функции миокарда");
            listBoxCategory.Items.Add("Препараты, влияющие на функцию почек");
            listBoxCategory.Items.Add("Противовирусные препараты");
            listBoxCategory.Items.Add("Противовоспалительные и обезболивающие препараты");
            listBoxCategory.Items.Add("Противогрибковые препараты");
            listBoxCategory.Items.Add("Противоопухолевые препараты");
            listBoxCategory.Items.Add("Противопаразитарные и противоглистные препараты");

            listBoxCategory.SelectedIndex = 0;

            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        #region "Работа с БД"
        private void LoadData()
        {
            try
            {
                string connectionString = @"Server=MAKUOSPC\SQLEXPRESS;Database=Products;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = category;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                //this.Close();
            }
        }

        private void LoadDataWithSearch(string searchText)
        {
            try
            {
                string connectionString = @"Server=MAKUOSPC\SQLEXPRESS;Database=Products;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(category, conn))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void LoadProductDetails(string productName, string productPrice)
        {
            string connectionString = @"Server=MAKUOSPC\SQLEXPRESS;Database=Products;Integrated Security=True;";
            string query = "SELECT Name, Price, Description, Image, Form FROM products WHERE Name = @name AND Price = @price  ORDER BY Name ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", productName);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(productPrice, CultureInfo.InvariantCulture));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelName.Text = "Название: " + reader["Name"].ToString();
                            labelPrice.Text = "Цена: " + reader["Price"].ToString();
                            labelDescription.Text = "Описание: " + reader["Description"].ToString();

                            labelName.Visible = true;
                            labelPrice.Visible = true;
                            labelDescription.Visible = true;
                            labelForm.Visible = true;
                            buttonAerozole.Visible = true;
                            buttonHard.Visible = true;
                            buttonLiquid.Visible = true;
                            buttonSoft.Visible = true;
                            pictureBoxImage.Visible = true;

                            string imageName = reader["Image"].ToString();
                            string imagePath = @"C:\Users\andre\source\repos\isrpo_apteka\isrpo_apteka\bin\Debug\images\" + imageName;

                            if (System.IO.File.Exists(imagePath))
                                pictureBoxImage.Image = Image.FromFile(imagePath);
                            else
                                pictureBoxImage.Image = null;

                            string form = reader["Form"].ToString();
                            buttonHard.BackColor = (form == "Твердый") ? Color.Aquamarine : Color.White;
                            buttonSoft.BackColor = (form == "Мягкий") ? Color.Aquamarine : Color.White;
                            buttonAerozole.BackColor = (form == "Аэрозоль") ? Color.Aquamarine : Color.White;
                            buttonLiquid.BackColor = (form == "Жидкий") ? Color.Aquamarine : Color.White;
                        }
                    }
                }
            }
        }   
        #endregion

        #region "Категории"
        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSearchCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedIndex == 0)
            {
                // Без категории
                category = "SELECT Name, Price FROM products ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 1)
            {
                // Антибактериальные препараты.
                category = "SELECT Name, Price FROM products WHERE Category = 'Антибактериальные препараты' ORDER BY Name ASC";
                LoadData();

            }
            else if (listBoxCategory.SelectedIndex == 2)
            {
                // Гормоны.
                category = "SELECT Name, Price FROM products WHERE Category = 'Гормоны.' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 3)
            {
                // Диагностические средства.
                category = "SELECT Name, Price FROM products WHERE Category = 'Диагностические средства' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 4)
            {
                // Препараты, влияющие на иммунитет.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты, влияющие на иммунитет' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 5)
            {
                // Препараты влияющие на метаболизм.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты влияющие на метаболизм' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 6)
            {
                // Препараты влияющие на психику.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты влияющие на психику' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 7)
            {
                // Препараты, влияющие на свертываемость крови.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты, влияющие на свертываемость крови' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 8)
            {
                // Препараты, влияющие на тонус сосудов.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты, влияющие на тонус сосудов' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 9)
            {
                // Препараты, влияющие на функцию бронхов.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты, влияющие на функцию бронхов' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 10)
            {
                // Препараты, влияющие на функции желудочно-кишечного тракта.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты, влияющие на функции желудочно-кишечного тракта' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 11)
            {
                // Препараты, влияющие на функции миокарда.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты, влияющие на функции миокарда' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 12)
            {
                // Препараты, влияющие на функцию почек.
                category = "SELECT Name, Price FROM products WHERE Category = 'Препараты, влияющие на функцию почек' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 13)
            {
                // Противовирусные препараты.
                category = "SELECT Name, Price FROM products WHERE Category = 'Противовирусные препараты' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 14)
            {
                // Противовоспалительные и обезболивающие препараты.
                category = "SELECT Name, Price FROM products WHERE Category = 'Противовоспалительные и обезболивающие препараты' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 15)
            {
                // Противогрибковые препараты.
                category = "SELECT Name, Price FROM products WHERE Category = 'Противогрибковые препараты' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 16)
            {
                // Противоопухолевые препараты.
                category = "SELECT Name, Price FROM products WHERE Category = 'Противоопухолевые препараты' ORDER BY Name ASC";
                LoadData();
            }
            else if (listBoxCategory.SelectedIndex == 17)
            {
                // Противопаразитарные и противоглистные препараты.
                category = "SELECT Name, Price FROM products WHERE Category = 'Противопаразитарные и противоглистные препараты' ORDER BY Name ASC";
                LoadData();
            }
            else
            {
                category = "SELECT Name, Price FROM products ORDER BY Name ASC";
                LoadData();
            }
        }

        private string GetProductCategory(string productName, string productPrice)
        {
            string category = string.Empty;
            string connectionString = @"Server=MAKUOSPC\SQLEXPRESS;Database=Products;Integrated Security=True;";
            string query = "SELECT Category FROM products WHERE Name = @name AND Price = @price";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", productName);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(productPrice, CultureInfo.InvariantCulture));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            category = reader["Category"].ToString();
                        }
                    }
                }
            }

            return category;
        }

        private void SetCategoryIndex(string category)
        {
            switch (category)
            {
                case "Без категории":
                    listBoxCategory.SelectedIndex = 0;
                    break;
                case "Антибактериальные препараты":
                    listBoxCategory.SelectedIndex = 1;
                    break;
                case "Гормоны":
                    listBoxCategory.SelectedIndex = 2;
                    break;
                case "Диагностические средства":
                    listBoxCategory.SelectedIndex = 3;
                    break;
                case "Препараты, влияющие на иммунитет":
                    listBoxCategory.SelectedIndex = 4;
                    break;
                case "Препараты влияющие на метаболизм":
                    listBoxCategory.SelectedIndex = 5;
                    break;
                case "Препараты влияющие на психику":
                    listBoxCategory.SelectedIndex = 6;
                    break;
                case "Препараты, влияющие на свертываемость крови":
                    listBoxCategory.SelectedIndex = 7;
                    break;
                case "Препараты, влияющие на тонус сосудов":
                    listBoxCategory.SelectedIndex = 8;
                    break;
                case "Препараты, влияющие на функцию бронхов":
                    listBoxCategory.SelectedIndex = 9;
                    break;
                case "Препараты, влияющие на функции желудочно-кишечного тракта":
                    listBoxCategory.SelectedIndex = 10;
                    break;
                case "Препараты, влияющие на функции миокарда":
                    listBoxCategory.SelectedIndex = 11;
                    break;
                case "Препараты, влияющие на функцию почек":
                    listBoxCategory.SelectedIndex = 12;
                    break;
                case "Противовирусные препараты":
                    listBoxCategory.SelectedIndex = 13;
                    break;
                case "Противовоспалительные и обезболивающие препараты":
                    listBoxCategory.SelectedIndex = 14;
                    break;
                case "Противогрибковые препараты":
                    listBoxCategory.SelectedIndex = 15;
                    break;
                case "Противоопухолевые препараты":
                    listBoxCategory.SelectedIndex = 16;
                    break;
                case "Противопаразитарные и противоглистные препараты":
                    listBoxCategory.SelectedIndex = 17;
                    break;
                default:
                    listBoxCategory.SelectedIndex = -1;
                    break;
            }
        }
        #endregion

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                category = "SELECT Name, Price FROM products ORDER BY Name ASC";
            }
            else
            {
                category = "SELECT Name, Price FROM products WHERE Name LIKE @search ORDER BY Name ASC";
            }

            LoadDataWithSearch(searchText);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedName = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                string selectedPrice = dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString();

                LoadProductDetails(selectedName, selectedPrice);

                string selectedCategory = GetProductCategory(selectedName, selectedPrice);

                SetCategoryIndex(selectedCategory);
            }
        }

        private void buttonArrowLeft_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.Index > 0)
            {
                int rowIndex = dataGridView1.CurrentRow.Index - 1;
                dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
                LoadSelectedProduct();
            }
        }

        private void buttonArrowRight_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 2)
            {
                int rowIndex = dataGridView1.CurrentRow.Index + 1;
                dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
                LoadSelectedProduct();
            }
        }

        private void LoadSelectedProduct()
        {
            if (dataGridView1.CurrentRow != null)
            {
                string name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                string price = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
                LoadProductDetails(name, price);
            }
        }

        
    }
}
