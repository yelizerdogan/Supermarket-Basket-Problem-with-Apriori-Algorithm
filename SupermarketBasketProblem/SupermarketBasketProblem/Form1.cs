using Cotur.DataMining.Association;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketBasketProblem
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataFields dataFields = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Alışveriş fişlerinde bulunan ürünlerin listesi

            List<string> FieldNames = new List<string>() { "Su", "Ekmek", "Yumurta", "Peynir", "Cips", "Kola", "Oyuncak" };



            // Alışveriş fişleri - hangi ürünler alınmış?

            List<List<int>> Transactions = new List<List<int>>() {
                new List<int>(){0,1,2,3,4,5,6},
                new List<int>(){0,2,3,5,6},
                new List<int>(){0,1,2,3},
                new List<int>(){2,4,6},
                new List<int>(){1,2,4,6},
                new List<int>(){4,5},
                new List<int>(){2,3,4},
                new List<int>(){0,2,4,6},
                new List<int>(){1,3,5}
            };

            // ürün çeşidi miktarı, alışveriş listesi, ürün isimleri listesiyle oluşturulan dataFields
            dataFields = new DataFields(7, Transactions, FieldNames);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // dataFields nesnesine göre oluşturulan Apriori
            Apriori apriori = new Apriori(dataFields);

            // Minumum destek oranı 0.25 ile hesaplanması // eşik değer
            apriori.CalculateCNodes(0.25f);
            


            foreach (var levels in apriori.EachLevelOfNodes)
            {
                
                foreach (var node in levels)
                {
                    // Birliktelik tabloları
                    lsbFieldNames.Items.Add(node.ToDetailedString(dataFields).ToString());
                   
                }
                lsbFieldNames.Items.Add("--------------------------");
            }
            foreach (var rules in apriori.Rules)
            {
                // Birliktelik kuralları
                lsbRules.Items.Add(rules.ToDetailedString(dataFields).ToString());
            }

        }

    }
}
