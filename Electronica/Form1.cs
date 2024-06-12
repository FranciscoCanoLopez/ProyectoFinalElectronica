using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using OfficeOpenXml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Xceed.Words.NET;
using TableXceed = Xceed.Document.NET.Table;
using DocumentXceed = Xceed.Document.NET.Document;


namespace Electronica
{
    public partial class F : Form
    {
        readonly string basePath = @"C:\Users\volub\source\repos\Electronica\Dispositivos\"; //direccion donde se ubican los
                                                                                             // a vender

        public F()
        {
            InitializeComponent();
            //Se configura la listview de carrito de compras
            listView1.View = View.Details;
            ColumnHeader columnType = new()
            {
                Text = "Type",
                Width = 100
            };

            ColumnHeader columnBrandModel = new()
            {
                Text = "Brand and Model",
                Width = 200
            };

            ColumnHeader columnPrice = new()
            {
                Text = "Price",
                Width = 100
            };

            kart.Columns.Add(columnType);
            kart.Columns.Add(columnBrandModel);
            kart.Columns.Add(columnPrice);

            //se configura la lista de historial de ventas

            SalesHistory.View = View.Details;
            SalesHistory.Columns.Add("Purchase Date and Time", 200);
            SalesHistory.Columns.Add("Purchased Devices", 400);
            SalesHistory.Columns.Add("Total Purchase", 100);
        }
        //combobox para opciones
        private void CBoptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = CBoptions.SelectedItem!.ToString()!;
            LoadContent(category);
        }
        //carga los datos de la opcion seleccionada
        private void LoadContent(string category)
        {
            var filename = string.Empty;

            switch (category)
            {
                case "Cell Phones":
                    filename = Path.Combine(basePath, "Cell Phones.txt");
                    break;
                case "Computers":
                    filename = Path.Combine(basePath, "Computers.txt");
                    break;
                case "Tablets":
                    filename = Path.Combine(basePath, "Tablets.txt");
                    break;
            }

            if (!string.IsNullOrEmpty(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);

                    listView1.Columns.Clear();
                    listView1.Items.Clear();
                    listView1.View = View.List;
                    ColumnHeader column = new()
                    {
                        Width = 150,
                        TextAlign = HorizontalAlignment.Center
                    };
                    listView1.Columns.Add(column);

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split(',');
                        ListViewItem item = new(data[0]);
                        listView1.Items.Add(item);
                    }
                }
                catch (FileNotFoundException)
                {
                    listView1.Items.Clear();
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Error");
                    listView1.Items.Add($"No se encontró el archivo para {category}");
                }
            }
        }
        //muestra los datos del dispositivo seleccionado
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedItem = listView1.SelectedItems[0].Text;

                string category = CBoptions.SelectedItem!.ToString()!;
                string filename = Path.Combine(basePath + category + ".txt");
                if (File.Exists(filename))
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filename);
                        foreach (string line in lines)
                        {
                            string[] data = line.Split(',');
                            if (data[0] == selectedItem)
                            {
                                if (category == "Cell Phones")
                                {
                                    var cellPhone = new CellPhone(
                                        category, data[0], data[1], data[2], data[3],
                                        data[4], data[5], data[6], data[7], decimal.Parse(data[8]));

                                    label1.Text = "Type: " + cellPhone.Category;
                                    label2.Text = "Brand and Model: " + cellPhone.BrandAndModel;
                                    label3.Text = "Screen: " + cellPhone.Screen;
                                    label4.Text = "Processor: " + cellPhone.Processor;
                                    label5.Text = "RAM: " + cellPhone.RAM;
                                    label6.Text = "Storage: " + cellPhone.Storage;
                                    label7.Text = "Main Camera: " + cellPhone.MainCamera;
                                    label8.Text = "Front Camera: " + cellPhone.FrontCamera;
                                    label9.Text = "Battery: " + cellPhone.Battery;
                                    label10.Text = "Price(USD): $" + cellPhone.Price;
                                    lblWarrenty.Text = $"Warrenty: {cellPhone.GetWarrantyInfo()}";
                                }
                                else if (category == "Computers")
                                {
                                    var computer = new Computer(
                                        category, data[0], data[1], data[2], data[3],
                                        data[4], data[5], data[6], decimal.Parse(data[8]));

                                    label1.Text = "Type: " + computer.Category;
                                    label2.Text = "Brand and Model: " + computer.BrandAndModel;
                                    label3.Text = "Screen: " + computer.Screen;
                                    label4.Text = "Processor: " + computer.Processor;
                                    label5.Text = "RAM: " + computer.RAM;
                                    label6.Text = "Storage: " + computer.Storage;
                                    label7.Text = "Graphics: " + computer.Graphics;
                                    label8.Text = "Operating System: " + computer.OperatingSystem;
                                    label9.Text = "";
                                    label10.Text = "Price(USD): $" + computer.Price;
                                    lblWarrenty.Text = $"Warrenty: {computer.GetWarrantyInfo()}";
                                }
                                else if (category == "Tablets")
                                {
                                    var tablet = new Tablet(
                                        category, data[0], data[1], data[2], data[3],
                                        data[4], data[5], data[6], data[7], decimal.Parse(data[8]));

                                    label1.Text = "Type: " + tablet.Category;
                                    label2.Text = "Brand and Model: " + tablet.BrandAndModel;
                                    label3.Text = "Screen: " + tablet.Screen;
                                    label4.Text = "Processor: " + tablet.Processor;
                                    label5.Text = "RAM: " + tablet.RAM;
                                    label6.Text = "Storage: " + tablet.Storage;
                                    label7.Text = "Main Camera: " + tablet.MainCamera;
                                    label8.Text = "Front Camera: " + tablet.FrontCamera;
                                    label9.Text = "Battery: " + tablet.Battery;
                                    label10.Text = "Price(USD): $" + tablet.Price;
                                    lblWarrenty.Text = $"Warrenty: {tablet.GetWarrantyInfo()}";
                                }
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo: " + filename, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //agrega el dispositivo seleccionado al carrito
        private void BtnAddToKart_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                string selectedItem = listView1.SelectedItems[0].Text;

                string category = CBoptions.SelectedItem!.ToString()!;

                string filename = Path.Combine(basePath + category + ".txt");
                if (File.Exists(filename))
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filename);
                        foreach (string line in lines)
                        {
                            string[] data = line.Split(',');
                            if (data[0] == selectedItem)
                            {
                                // Agrega los datos a la ListView "kart"
                                ListViewItem item = new()
                                {
                                    Text = category // Tipo
                                };
                                item.SubItems.Add(data[0]);
                                item.SubItems.Add(data[8]);
                                kart.Items.Add(item);
                                UpdateTotalPrice();
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo: " + filename, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para agregar al carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //actualiza precio al agregar o eliminar dispositivos al carrito
        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (ListViewItem item in kart.Items)
            {
                string priceString = item.SubItems[2].Text;

                // Elimina caracteres no numéricos
                priceString = MyRegex().Replace(priceString, "");

                try
                {
                    decimal price = decimal.Parse(priceString, CultureInfo.InvariantCulture);
                    totalPrice += price;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error al convertir el precio: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Muestra la suma total en la label
            lblTotalPrice.Text = "Total Price: $" + totalPrice.ToString("0.00");
        }
        //remueve el dispositivo seleccionado del carrito
        private void BtnRemoveFromKart_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in kart.SelectedItems)
            {
                kart.Items.Remove(item);
            }
            UpdateTotalPrice();
        }
        //agrega fecha y hora, dispositivos comprados y el precio total a pagar
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            // Combina los datos de los dispositivos comprados en un solo string
            string purchasedDevices = string.Join(", ", kart.Items.Cast<ListViewItem>().Select(item => item.SubItems[1].Text));

            // Crea una nueva fila con la fecha, los dispositivos comprados y el precio total
            ListViewItem newItem = new()
            {
                Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
            newItem.SubItems.Add(purchasedDevices);
            newItem.SubItems.Add(lblTotalPrice.Text);

            SalesHistory.Items.Add(newItem);

            kart.Items.Clear();
            UpdateTotalPrice();

            MessageBox.Show("Compra realizada con éxito.", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //botones para exportar a diferentes formatos
        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\volub\source\repos\Electronica\Sales History\Excel";
            Directory.CreateDirectory(folderPath);

            using SaveFileDialog sfd = new()
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save Sales History to Excel",
                InitialDirectory = folderPath
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;

                try
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using ExcelPackage package = new();
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sales History");

                    worksheet.Cells[1, 1].Value = "Purchase Date and Time";
                    worksheet.Cells[1, 2].Value = "Purchased Devices";
                    worksheet.Cells[1, 3].Value = "Total Purchase";

                    for (int i = 0; i < SalesHistory.Items.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = SalesHistory.Items[i].Text;
                        worksheet.Cells[i + 2, 2].Value = SalesHistory.Items[i].SubItems[1].Text;
                        worksheet.Cells[i + 2, 3].Value = SalesHistory.Items[i].SubItems[2].Text;
                    }

                    FileInfo fi = new(filePath);
                    package.SaveAs(fi);

                    MessageBox.Show("Historial de ventas exportado a Excel con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the exported file
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportToPDF_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\volub\source\repos\Electronica\Sales History\PDF";
            Directory.CreateDirectory(folderPath);

            using SaveFileDialog sfd = new()
            {
                Filter = "PDF Files|*.pdf",
                Title = "Save Sales History to PDF",
                InitialDirectory = folderPath
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;

                try
                {
                    using FileStream fs = new(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
                    Document doc = new(PageSize.A4, 10, 10, 10, 10);

                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Add content to the PDF document
                    PdfPTable table = new(3)
                    {
                        WidthPercentage = 100
                    };
                    table.SetWidths(new float[] { 2, 5, 2 });

                    table.AddCell("Purchase Date and Time");
                    table.AddCell("Purchased Devices");
                    table.AddCell("Total Purchase");

                    foreach (ListViewItem item in SalesHistory.Items)
                    {
                        table.AddCell(item.Text);
                        table.AddCell(item.SubItems[1].Text);
                        table.AddCell(item.SubItems[2].Text);
                    }

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("Historial de ventas exportado a PDF con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the exported file
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportToWord_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\volub\source\repos\Electronica\Sales History\Word";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            using SaveFileDialog sfd = new()
            {
                Filter = "Word Documents|*.docx",
                Title = "Save Sales History to Word",
                InitialDirectory = folderPath
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;

                try
                {
                    using var doc = DocX.Create(filePath);
                    var table = doc.AddTable(SalesHistory.Items.Count + 1, 3);
                    table.Rows[0].Cells[0].Paragraphs[0].Append("Purchase Date and Time");
                    table.Rows[0].Cells[1].Paragraphs[0].Append("Purchased Devices");
                    table.Rows[0].Cells[2].Paragraphs[0].Append("Total Purchase");

                    for (int i = 0; i < SalesHistory.Items.Count; i++)
                    {
                        table.Rows[i + 1].Cells[0].Paragraphs[0].Append(SalesHistory.Items[i].Text);
                        table.Rows[i + 1].Cells[1].Paragraphs[0].Append(SalesHistory.Items[i].SubItems[1].Text);
                        table.Rows[i + 1].Cells[2].Paragraphs[0].Append(SalesHistory.Items[i].SubItems[2].Text);
                    }

                    doc.InsertTable(table);
                    doc.Save();

                    MessageBox.Show("Historial de ventas exportado a Word con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the exported file
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a Word: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportToXML_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\volub\source\repos\Electronica\Sales History\XML";
            Directory.CreateDirectory(folderPath);

            using SaveFileDialog sfd = new()
            {
                Filter = "XML Files|*.xml",
                Title = "Save Sales History to XML",
                InitialDirectory = folderPath
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;

                try
                {
                    XmlDocument xmlDoc = new();
                    XmlElement root = xmlDoc.CreateElement("SalesHistory");

                    foreach (ListViewItem item in SalesHistory.Items)
                    {
                        XmlElement purchaseNode = xmlDoc.CreateElement("Purchase");

                        XmlElement dateTimeNode = xmlDoc.CreateElement("DateTime");
                        dateTimeNode.InnerText = item.Text;
                        purchaseNode.AppendChild(dateTimeNode);

                        XmlElement devicesNode = xmlDoc.CreateElement("Devices");
                        devicesNode.InnerText = item.SubItems[1].Text;
                        purchaseNode.AppendChild(devicesNode);

                        XmlElement totalPriceNode = xmlDoc.CreateElement("TotalPrice");
                        totalPriceNode.InnerText = item.SubItems[2].Text;
                        purchaseNode.AppendChild(totalPriceNode);

                        root.AppendChild(purchaseNode);
                    }

                    xmlDoc.AppendChild(root);
                    xmlDoc.Save(filePath);

                    MessageBox.Show("Historial de ventas exportado a XML con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the exported file
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportToJson_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\volub\source\repos\Electronica\Sales History\Json";
            Directory.CreateDirectory(folderPath);

            using SaveFileDialog sfd = new()
            {
                Filter = "JSON Files|*.json",
                Title = "Save Sales History to JSON",
                InitialDirectory = folderPath
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;

                try
                {
                    var salesHistoryList = SalesHistory.Items.Cast<ListViewItem>().Select(item =>
                        new
                        {
                            DateTime = item.Text,
                            Devices = item.SubItems[1].Text,
                            TotalPrice = item.SubItems[2].Text
                        }
                    );

                    string json = JsonConvert.SerializeObject(salesHistoryList, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Historial de ventas exportado a JSON con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the exported file
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportToTXT_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\volub\source\repos\Electronica\Sales History\TXT";
            Directory.CreateDirectory(folderPath);

            using SaveFileDialog sfd = new()
            {
                Filter = "Text Files|*.txt",
                Title = "Save Sales History to Text",
                InitialDirectory = folderPath
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;

                try
                {
                    using StreamWriter writer = new(filePath);

                    // Escribe la línea de encabezado
                    writer.WriteLine("Purchase Date and Time\tPurchased Devices\tTotal Purchase");

                    // Escribe las líneas de datos
                    foreach (ListViewItem item in SalesHistory.Items)
                    {
                        string dateTime = item.Text;
                        string devices = item.SubItems[1].Text;
                        string totalPrice = item.SubItems[2].Text;

                        writer.WriteLine($"{dateTime}\t{devices}\t{totalPrice}");
                    }

                    MessageBox.Show("Historial de ventas exportado a texto con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the exported file
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a texto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        [GeneratedRegex("[^0-9.]")]
        private static partial Regex MyRegex();
    }
}