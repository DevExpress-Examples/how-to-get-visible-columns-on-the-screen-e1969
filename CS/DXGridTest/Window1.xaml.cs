using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Utils.Themes;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core;
using System.Collections;
using System.Windows.Threading;

namespace DXGridTest {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            List<TestData> list = new List<TestData>();
            //for(int i = 0; i < 100; i++)
                //list.Add(new TestData() { Text = "Row" + i, Number = i, Group = i % 3 });
            gridControl1.DataSource = list;
        }

        private void gridControl1_ScrollChanged(object sender, ScrollChangedEventArgs e) {
            List<GridColumn> list = new List<GridColumn>();

            double offset = 0;
            foreach(GridColumn column in gridControl1.View.VisibleColumns) {
                offset += column.ActualHeaderWidth;
                if(offset < e.HorizontalOffset)
                    continue;
                list.Add(column);
                if(offset > e.HorizontalOffset + e.ViewportWidth)
                    break;
            }
            listBox.ItemsSource = list;
        }
    }

    public class TestData {
        public string Column0 { get; set; }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }
        public string Column8 { get; set; }
        public string Column9 { get; set; }
    }
}
