using ioINIScanner.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ioINIScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            if (ioData.LoadResourcePath() == false)
            {
                MessageBox.Show("리소스의 경로를 읽지 못했습니다.\n" + ioData.m_szINIPath + "를 다시 확인 해 주세요.");
                Environment.Exit(0);
            }

            MessageBox.Show("초기 로딩이 오래 걸릴 수 있습니다.\n잠시만 기다려주세요.","ioEnter");
            ioData.LoadItem();
            ioData.LoadExtraItem();
            ioData.LoadCostumeArmor();
            ioData.LoadCostumeCloak();
            ioData.LoadCostumeHelmet();
            ioData.LoadEtcItem();
            ioData.LoadMedalItem();
            ioData.LoadPetItem();

            //MessageBox.Show("로드 완료.","ioEnter");

            Init();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text.Length == 0)
            {
                MessageBox.Show("검색할 이름이 입력되지 않았습니다.","ioEnter");
                return;
            }

            Init();

            int iSize1 = ioData.vItemlist.Count; //아이템
            for (int i = 0; i < iSize1; i++)
            {
                if (ioData.vItemlist[i].m_szName.Contains(SearchBox.Text) == true)
                {
                    ItemBox.Items.Add(ioData.vItemlist[i].m_szName + ";" + ioData.vItemlist[i].m_iCode);
                }
            }

            int iSize2 = ioData.vExtraItemlist.Count; //엑스트라 아이템
            for (int i = 0; i < iSize2; i++)
            {
                if (ioData.vExtraItemlist[i].m_szName.Contains(SearchBox.Text) == true)
                {
                    ItemBox.Items.Add(ioData.vExtraItemlist[i].m_szName + ";" + ioData.vExtraItemlist[i].m_iCode);
                }
            }

            int iSize3 = ioData.vCostumelist.Count; //코스튬
            for (int i = 0; i < iSize3; i++)
            {
                if (ioData.vCostumelist[i].m_szName.Contains(SearchBox.Text) == true)
                {
                    CostumeBox.Items.Add(ioData.vCostumelist[i].m_szName + ";" + ioData.vCostumelist[i].m_iCode);
                }
            }

            int iSize4 = ioData.vEtcItemlist.Count; //ETC아이템
            for (int i = 0; i < iSize4; i++)
            {
                if (ioData.vEtcItemlist[i].m_szName.Contains(SearchBox.Text) == true)
                {
                    EtcItemBox.Items.Add(ioData.vEtcItemlist[i].m_szName + ";" + ioData.vEtcItemlist[i].m_iCode);
                }
            }

            int iSize5 = ioData.vMedalItemlist.Count; //메달 아이템
            for (int i = 0; i < iSize5; i++)
            {
                if (ioData.vMedalItemlist[i].m_szName.Contains(SearchBox.Text) == true)
                {
                    MedalBox.Items.Add(ioData.vMedalItemlist[i].m_szName + ";" + ioData.vMedalItemlist[i].m_iCode);
                }
            }

            int iSize6 = ioData.vPetItemlist.Count; //펫 아이템
            for (int i = 0; i < iSize6; i++)
            {
                if (ioData.vPetItemlist[i].m_szName.Contains(SearchBox.Text) == true)
                {
                    PetBox.Items.Add(ioData.vPetItemlist[i].m_szName + ";" + ioData.vPetItemlist[i].m_iCode + ";" + ioData.vPetItemlist[i].m_iRank);
                }
            }

            SearchBox.Text = "";
        }

        private void ItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = ItemBox.SelectedItem.ToString();
                string[] curItemSplit = curItem.Split(';');
                string szItemName = curItemSplit[0];
                string szItemCode = curItemSplit[1];
                DetailText.Text = "< 장비 아이템 >\r\n이름 : " + szItemName + "\r\n코드 : " + szItemCode + "\r\n양식 : 5." + szItemCode + ".시간";
            }
            catch
            {
                DetailText.Text = "";
            }
        }

        private void EtcItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = EtcItemBox.SelectedItem.ToString();
                string[] curItemSplit = curItem.Split(';');
                string szItemName = curItemSplit[0];
                string szItemCode = curItemSplit[1];
                DetailText.Text = "< ETC 아이템 >\r\n이름 : " + szItemName + "\r\n코드 : " + szItemCode + "\r\n양식 : 3." + szItemCode + ".개수";
            }
            catch
            {
                DetailText.Text = "";
            }
        }

        private void CostumeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = CostumeBox.SelectedItem.ToString();
                string[] curItemSplit = curItem.Split(';');
                string szItemName = curItemSplit[0];
                string szItemCode = curItemSplit[1];
                DetailText.Text = "< 코스튬 아이템 >\r\n이름 : " + szItemName + "\r\n코드 : " + szItemCode + "\r\n양식 : 12." + szItemCode + ".시간";
            }
            catch
            {
                DetailText.Text = "";
            }
        }

        private void MedalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = MedalBox.SelectedItem.ToString();
                string[] curItemSplit = curItem.Split(';');
                string szItemName = curItemSplit[0];
                string szItemCode = curItemSplit[1];
                DetailText.Text = "< 메달 아이템 >\r\n이름 : " + szItemName + "\r\n코드 : " + szItemCode + "\r\n양식 : 9." + szItemCode + ".시간";
            }
            catch
            {
                DetailText.Text = "";
            }
        }

        private void PetBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = PetBox.SelectedItem.ToString();
                string[] curItemSplit = curItem.Split(';');
                string szItemName = curItemSplit[0];
                string szItemCode = curItemSplit[1];
                string szItemRank = curItemSplit[2];
                DetailText.Text = "< 펫 아이템 >\r\n이름 : " + szItemName + "\r\n코드 : " + szItemCode + "\r\n최대랭크 : " + szItemRank + "\r\n양식 : 11." + szItemCode + ".랭크";
            }
            catch
            {
                DetailText.Text = "";
            }
        }

        private void Init()
        {
            EtcItemBox.Items.Clear();
            ItemBox.Items.Clear();
            CostumeBox.Items.Clear();
            MedalBox.Items.Clear();
            PetBox.Items.Clear();


            EtcItemBox.Items.Add("           [ETC 아이템]");
            EtcItemBox.Items.Add("");

            ItemBox.Items.Add("           [장비 아이템]");
            ItemBox.Items.Add("");

            CostumeBox.Items.Add("          [코스튬 아이템]");
            CostumeBox.Items.Add("");

            MedalBox.Items.Add("           [메달 아이템]");
            MedalBox.Items.Add("");

            PetBox.Items.Add("            [펫 아이템]");
            PetBox.Items.Add("");
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;

            SearchBtn.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
