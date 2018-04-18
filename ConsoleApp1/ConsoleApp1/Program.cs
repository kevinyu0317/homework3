using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                // 設定顏色
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;

                //資料

                string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
                string[] genders = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
                string[] bloodtype = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
                string[] constellation = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
                int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

                // 開頭

                Console.WriteLine("用全班資料計算：");
                Console.WriteLine(" ");

                //設變數

                int countW = 0;
                int countM = 0;
                int countA = 0;
                int countB = 0;
                int countAB = 0;
                int countO = 0;
                int count = 0;
                int boy = 0;
                int girl = 0;
                int sum = 0;


                //個數

                for (int i = 0; i < genders.Length; i++)
                {

                    if (genders[i] == "女")
                    {
                        girl++;
                    }
                    if (genders[i] == "男")
                    {
                        boy++;
                    }

                }

                // 身高

                int sumW = 0;
                int sumM = 0;


                for (int i = 0; i < height.Length; i++)
                {
                    if (height[i] > 100 && height[i] < 200)
                    {
                        if (genders[i] == "女")
                        {
                            sumW = sumW + height[i];
                            countW++;
                        }
                    }

                    if (height[i] > 100 && height[i] < 200)
                    {
                        if (genders[i] == "男")
                        {
                            sumM = sumM + height[i];
                            countM++;
                        }
                    }
                }

                //全班身高
                for (int i = 0; i < height.Length; i++)
                {
                    if (height[i] > 100 && height[i] < 200)
                    {
                        sum = sum + height[i];
                        count++;
                    }
                }


                //平均身高

                double averageheightW = sumW / countW;
                double averageheightM = sumM / countM;
                double averageall = sum / count;


                //血型

                for (int i = 0; i < bloodtype.Length; i++)
                {
                    if (bloodtype[i] == "A")
                    {
                        countA += 1;
                    }

                    else if (bloodtype[i] == "B")
                    {
                        countB += 1;
                    }

                    else if (bloodtype[i] == "AB")
                    {
                        countAB += 1;
                    }

                    else if (bloodtype[i] == "O")
                    {
                        countO += 1;
                    }

                    else
                        count += 1;



                }




                //百分比

                double percentM = (double)countM / (double)genders.Length * 100;
                double percentW = (double)countW / (double)genders.Length * 100;
                double perA = (double)countA / (double)bloodtype.Length * 100;
                double perB = (double)countB / (double)bloodtype.Length * 100;
                double perAB = (double)countAB / (double)bloodtype.Length * 100;
                double perO = (double)countO / (double)bloodtype.Length * 100;



                //顯示

                Console.WriteLine("女生人數:{0} 佔:{1:0}%", countW, percentW);
                Console.WriteLine("男生人數:{0} 佔:{1:0}%", countM, percentM);
                Console.WriteLine("A型人數:{0} 佔:{1:0}%", countA, perA);
                Console.WriteLine("B型人數:{0} 佔:{1:0}%", countB, perB);
                Console.WriteLine("AB型人數:{0} 佔:{1:0}%", countAB, perAB);
                Console.WriteLine("O型人數:{0} 佔:{1:0}%", countO, perO);
                Console.WriteLine("女生身高總和為:" + sumW + "平均為:" + averageheightW);
                Console.WriteLine("男生身高總和為:" + sumM + "平均為:" + averageheightM);
                Console.WriteLine("全班身高總和為:" + sum + "平均為:" + averageall);


                //屬於天蠍座O型的人

                for (int i = 0; i < constellation.Length; i++)
                {
                    if (constellation[i] == "天蠍" && bloodtype[i] == "O")
                    {
                        Console.WriteLine("天蠍座O型的人為:" + name[i]);
                    }


                }


                // 找出班上最高與最矮身高
                int max = 0;
                int min = 999;

                for (int i = 0; i < height.Length; i++)
                {
                    if (height[i] > 100 && height[i] < 200)
                    {
                        if (height[i] > max)
                        {
                            max = height[i];
                        }
                        if (height[i] < min)
                        {
                            min = height[i];
                        }
                    }
                }

                // 顯示班上最高與最矮身高
                Console.WriteLine("班上最高的身高:" + max);
                Console.WriteLine("班上最矮的身高:" + min);





                //結束
                Console.ReadLine();
            }
        }
    }
