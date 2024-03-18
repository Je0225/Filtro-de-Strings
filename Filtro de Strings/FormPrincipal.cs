using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Filtro_de_Strings {

    public partial class FormPrincipal: Form {

        private readonly List<String> nomes;

        public FormPrincipal() {
            InitializeComponent();
            nomes = new List<String>();
        }

        private void bntAdd_Click(object sender, EventArgs e) {
            if (!tbNome.Text.Equals("")) {
                nomes.Add(tbNome.Text);
                popupaLista(nomes, lvNomes);
                tbNome.Clear();
            }
            tbNome.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            String filtro = tbFiltro.Text.ToLower();
            if (!filtro.Equals("")) {
                List<String> selecionados = new List<String>();
                foreach (String nome in nomes) {
                    if (nome.ToLower().Contains(filtro)) {
                        selecionados.Add(nome);
                    }
                }
                popupaLista(selecionados, lvFiltro);
                tbFiltro.Clear();
            }
            tbFiltro.Focus();
        }

        private void popupaLista(List<String> lista, ListView listView) {
            listView.Items.Clear();
            foreach (String nome in lista) {
                listView.Items.Add(new ListViewItem(new[] {nome}));
            }
        }

    }

}