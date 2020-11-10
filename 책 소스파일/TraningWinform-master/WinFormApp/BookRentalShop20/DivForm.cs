using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class DivForm : MetroFramework.Forms.MetroForm
    {
        public DivForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'bookrentalshopDBDataSet.divtbl' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.divtblTableAdapter.Fill(this.bookrentalshopDBDataSet.divtbl);

        }

        private void txtNames_Click(object sender, EventArgs e)
        {

        }
    }
}
