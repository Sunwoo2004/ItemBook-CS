using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioINIScanner
{
    internal class ioData
    {
        public static string m_szINIPath = "config/ioINIScanner.ini";
        public static string m_szResourcePath = "";

        //장비 아이템 시작
        public static List<ioItem> vItemlist = new List<ioItem>();
        public static List<ioItem> vExtraItemlist = new List<ioItem>();
        //장비 아이템 끝

        //코스튬 시작
        public static List<ioItem> vCostumelist = new List<ioItem>();
        //코스튬 끝

        //ETC 아이템 시작
        public static List<ioItem> vEtcItemlist = new List<ioItem>();
        //ETC 아이템 끝

        //메달 아이템 시작
        public static List<ioItem> vMedalItemlist = new List<ioItem>();
        //메달 아이템 끝

        //펫 아이템 시작
        public static List<ioPet> vPetItemlist = new List<ioPet>();
        //펫 아이템 끝
        public static bool LoadResourcePath()
        {
            ioINILoader kLoader = new ioINILoader();
            kLoader.SetFileName(m_szINIPath);
            kLoader.SetTitle("resource");
            string szPath = kLoader.LoadString("path", "");
            if (szPath == "")
            {
                return false;
            }

            m_szResourcePath = szPath;

            return true;
        }

        public static void LoadItem()
        {
            ioINILoader kLoader = new ioINILoader();

            string szINIPath = m_szResourcePath + "config/sp2_item.ini";

            kLoader.SetFileName(szINIPath); //파일 경로 설정

            kLoader.SetTitle("common_info");

            int iCnt = kLoader.LoadInt("item_group_cnt", 0);

            for (int i = 0; i < iCnt; i++)
            {
                string szItemGroupNum = $"item_group{i}";
                string szItemPath = kLoader.LoadString(szItemGroupNum,"");
                string szPath = m_szResourcePath + "config/" + szItemPath;
                ioINILoader kLoader2 = new ioINILoader();
                kLoader2.SetFileName(szPath);
                kLoader2.SetTitle("common");

                int item_cnt = kLoader2.LoadInt("item_cnt", 0);
                for (int j = 0; j < item_cnt; j++)
                {
                    ioItem item = new ioItem();
                    string szItemTitle = $"item{j + 1}";
                    kLoader2.SetTitle(szItemTitle);
                    string szItemName = kLoader2.LoadString("name", "");
                    item.m_szName = szItemName;
                    item.m_iCode = kLoader2.LoadInt("code", 0);
                    vItemlist.Add(item);
                }
            }
        }

        public static void LoadExtraItem()
        {
            ioINILoader kLoader = new ioINILoader();

            string szINIPath = m_szResourcePath + "config/sp2_extraitem.ini";

            kLoader.SetFileName(szINIPath); //파일 경로 설정

            kLoader.SetTitle("common_info");

            int iCnt = kLoader.LoadInt("item_group_cnt", 0);

            for (int i = 0; i < iCnt; i++)
            {
                string szItemGroupNum = $"item_group{i}";
                string szItemPath = kLoader.LoadString(szItemGroupNum, "");
                string szPath = m_szResourcePath + "config/" + szItemPath;
                ioINILoader kLoader2 = new ioINILoader();
                kLoader2.SetFileName(szPath);
                kLoader2.SetTitle("common");

                int item_cnt = kLoader2.LoadInt("item_cnt", 0);
                for (int j = 0; j < item_cnt; j++)
                {
                    ioItem item = new ioItem();
                    string szItemTitle = $"item{j + 1}";
                    kLoader2.SetTitle(szItemTitle);
                    string szItemName = kLoader2.LoadString("name", "");
                    item.m_szName = szItemName;
                    item.m_iCode = kLoader2.LoadInt("code", 0);
                    vExtraItemlist.Add(item);
                }
            }
        }

        public static void LoadCostumeArmor()
        {
            ioINILoader kLoader = new ioINILoader();
            string szINIPath = m_szResourcePath + "config/costume/costume_armor.ini";
            kLoader.SetFileName(szINIPath);
            kLoader.SetTitle("common_info");
            int iCnt = kLoader.LoadInt("costume_cnt", 0);

            for (int i = 0; i < iCnt; i++)
            {
                ioItem item = new ioItem();
                string szItemTitle = $"costume{i + 1}";
                kLoader.SetTitle(szItemTitle);
                string szItemName = kLoader.LoadString("name", "");
                item.m_szName = szItemName;
                item.m_iCode = kLoader.LoadInt("costum_code", 0);
                if (item.m_iCode == 0 || item.m_iCode < 0 || item.m_iCode > 1000000)
                {
                    continue;
                }
                vCostumelist.Add(item);
            }
        }
        public static void LoadCostumeCloak()
        {
            ioINILoader kLoader = new ioINILoader();
            string szINIPath = m_szResourcePath + "config/costume/costume_cloak.ini";
            kLoader.SetFileName(szINIPath);
            kLoader.SetTitle("common_info");
            int iCnt = kLoader.LoadInt("costume_cnt", 0);

            for (int i = 0; i < iCnt; i++)
            {
                ioItem item = new ioItem();
                string szItemTitle = $"costume{i + 1}";
                kLoader.SetTitle(szItemTitle);
                string szItemName = kLoader.LoadString("name", "");
                item.m_szName = szItemName;
                item.m_iCode = kLoader.LoadInt("costum_code", 0);
                if (item.m_iCode == 0 || item.m_iCode < 0 || item.m_iCode > 1000000)
                {
                    continue;
                }
                vCostumelist.Add(item);
            }
        }
        public static void LoadCostumeHelmet()
        {
            ioINILoader kLoader = new ioINILoader();
            string szINIPath = m_szResourcePath + "config/costume/costume_helmet.ini";
            kLoader.SetFileName(szINIPath);
            kLoader.SetTitle("common_info");
            int iCnt = kLoader.LoadInt("costume_cnt", 0);

            for (int i = 0; i < iCnt; i++)
            {
                ioItem item = new ioItem();
                string szItemTitle = $"costume{i + 1}";
                kLoader.SetTitle(szItemTitle);
                string szItemName = kLoader.LoadString("name", "");
                item.m_szName = szItemName;
                item.m_iCode = kLoader.LoadInt("costum_code", 0);
                if (item.m_iCode == 0 || item.m_iCode < 0 || item.m_iCode > 1000000)
                {
                    continue;
                }
                vCostumelist.Add(item);
            }
        }

        public static void LoadEtcItem()
        {
            ioINILoader kLoader = new ioINILoader();
            string szINIPath = m_szResourcePath + "config/sp2_etcitem_info.ini";
            kLoader.SetFileName(szINIPath);
            kLoader.SetTitle("common");

            int iCnt = kLoader.LoadInt("max",0);
            for (int i = 0; i < iCnt; i++)
            {
                ioItem item = new ioItem();
                string szTitleName = $"etcitem{i + 1}";
                kLoader.SetTitle(szTitleName);
                item.m_szName = kLoader.LoadString("name","");
                item.m_iCode = kLoader.LoadInt("type",0);
                if (item.m_iCode < 1)
                {
                    continue;
                }
                vEtcItemlist.Add(item);
            }
        }

        public static void LoadMedalItem()
        {
            ioINILoader kLoader = new ioINILoader();
            string szINIPath = m_szResourcePath + "config/sp2_medalitem_info.ini";
            kLoader.SetFileName(szINIPath);
            kLoader.SetTitle("item_info_common");

            int iCnt = kLoader.LoadInt("max_item_info", 0);
            for (int i = 0; i < iCnt; i++)
            {
                ioItem item = new ioItem();
                string szTitleName = $"item_info_{i + 1}";
                kLoader.SetTitle(szTitleName);
                item.m_szName = kLoader.LoadString("name", "");
                item.m_iCode = kLoader.LoadInt("item_type", 0);
                if (item.m_iCode < 1)
                {
                    continue;
                }
                vMedalItemlist.Add(item);
            }
        }

        public static void LoadPetItem()
        {
            ioINILoader kLoader = new ioINILoader();
            string szINIPath = m_szResourcePath + "config/sp2_pet_info.ini";
            kLoader.SetFileName(szINIPath);
            kLoader.SetTitle("pet_base_common");

            int iCnt = kLoader.LoadInt("max_base_info_cnt", 0);
            for (int i = 0; i < iCnt; i++)
            {
                ioPet item = new ioPet();
                string szTitleName = $"pet_base_info{i + 1}";
                kLoader.SetTitle(szTitleName);
                item.m_szName = kLoader.LoadString("pet_view1_name", "");
                item.m_iCode = kLoader.LoadInt("pet_code", 0);
                item.m_iRank = kLoader.LoadInt("pet_max_rank", 0);
                if (item.m_iCode < 1)
                {
                    continue;
                }
                vPetItemlist.Add(item);
            }
        }
    }
}
