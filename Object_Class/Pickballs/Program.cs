using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pickballs
{  
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] group = new int[] { 0, 3, 4, 6 };
            prinfgame(group);
            try
            {
                Console.WriteLine("bạn muốn đi trước hay đi sau (truoc/sau)");
                string quyendi = Console.ReadLine();
                if (quyendi.ToLower().Equals("truoc"))
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("nguoi choi chon group: ");
                            int pickgroup = int.Parse(Console.ReadLine());
                            Console.WriteLine("nguoi choi muon boc may vien: ");
                            int pickball = int.Parse(Console.ReadLine());
                            if (group[pickgroup] < pickball) throw new Exception();
                            humanmove(group, pickgroup, pickball);
                            if (has0group(group))
                            {
                                Console.WriteLine("you lose");
                                break;
                            }
                            Console.WriteLine("Máy đang suy nghĩ ....");
                            Thread.Sleep(1400);
                            Computermove(group);
                            if (has0group(group))
                            {
                                Console.WriteLine("you win");
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("lỗi");
                            Console.WriteLine("vui lòng nhập lại");
                        }
                    }
                }
                else if (quyendi.ToLower().Equals("sau"))
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Máy đang suy nghĩ ....");
                            Thread.Sleep(1400);
                            Computermove(group);
                            if (has0group(group))
                            {
                                Console.WriteLine("you win");
                                break;
                            }
                            Console.WriteLine("nguoi choi chon group: ");
                            int pickgroup = int.Parse(Console.ReadLine());
                            Console.WriteLine("nguoi choi muon boc may vien: ");
                            int pickball = int.Parse(Console.ReadLine());
                            if (group[pickgroup] < pickball) throw new Exception();
                            humanmove(group, pickgroup, pickball);
                            if (has0group(group))
                            {
                                Console.WriteLine("you lose");
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("lỗi");
                            Console.WriteLine("vui lòng nhập lại");
                        }
                    }
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("lỗi");
                Console.WriteLine("vui lòng thoát và khởi động lại");
            }
            Console.ReadLine();
        }
        #region prinfgame
        static void prinfgame(int[] group)
        {
            Console.Write("group 1: ");
            for (int i = 0; i < group[1]; i++)
            {
                Console.Write('o');
            }
            Console.WriteLine();
            Console.Write("group 2: ");
            for (int i = 0; i < group[2]; i++)
            {
                Console.Write('o');
            }
            Console.WriteLine();
            Console.Write("group 3: ");
            for (int i = 0; i < group[3]; i++)
            {
                Console.Write('o');
            }
            Console.WriteLine();
        }
        #endregion

        #region pickball
        static void pickball(int[] group, int n, int m)
        {
            group[n] -= m;

        }
        #endregion

        #region has0group
        static bool has0group(int[] group)
        {
            if (group[1] == 0 && group[2] == 0 && group[3] == 0) return true;
            return false;
        }
        #endregion

        #region has1Group
        static bool has1Group(int[] group)
        {
            if (group[1] == 0 && group[2] == 0 && group[3] > 0)
            {
                return true;
            }
            else if (group[1] == 0 && group[2] > 0 && group[3] == 0)
            {
                return true;
            }
            else if (group[1] > 0 && group[2] == 0 && group[3] == 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region has2group
        static bool has2group(int[] group)
        {
            if (group[1] > 0 && group[2] > 0 && group[3] == 0)
                return true;
            else if (group[1] > 0 && group[2] == 0 && group[3] > 0)
                return true;
            else if (group[1] == 0 && group[2] > 0 && group[3] > 0)
                return true;
            return false;
        }
        #endregion

        #region has3group
        static bool has3group(int[] group)
        {
            return group[1] > 0 && group[2] > 0 && group[3] > 0;
        }
        #endregion

        #region get1group
        static void get1group(int[] group, out int a)
        {
            a = 0;
            if (group[1] > 0 && group[2] == 0 && group[3] == 0)
                a = 1;
            else if (group[1] == 0 && group[2] > 0 && group[3] == 0)
                a = 2;
            else if (group[1] == 0 && group[2] == 0 && group[3] > 0)
                a = 3;
        }
        #endregion

        #region get2group
        static void get2group(int[] group, out int a, out int b)
        {
            a = 0; b = 0;
            if (group[1] > 0 && group[2] > 0 && group[3] == 0)
            {
                a = 1;
                b = 2;
            }
            else if (group[1] > 0 && group[2] == 0 && group[3] > 0)
            {
                a = 1;
                b = 3;
            }
            else if (group[1] == 0 && group[2] > 0 && group[3] > 0)
            {
                a = 2;
                b = 3;
            }
        }
        #endregion

        #region get3group
        static void get3group(int[] group, out int a, out int b, out int c)
        {
            a = 0; b = 0; c = 0;
            if (group[1] > 0 && group[2] > 0 && group[3] > 0)
            {
                a = 1;
                b = 2;
                c = 3;
            }
        }
        #endregion

        #region humanmove
        public static void humanmove(int[] group, int g, int balls)
        {
            Console.WriteLine("lựa chọn của bạn là group {0}, bốc {1} ", g, balls);
            pickball(group, g, balls);
            prinfgame(group);
        }
        #endregion

        #region Computermove
        public static void Computermove(int[] group)
        {

            if (has1Group(group))
            {
                int a = 0;
                get1group(group, out a);
                if (group[a] > 1)
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", a, group[a] - 1);
                    pickball(group, a, group[a] - 1);
                }
                else
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", a, 1);
                    pickball(group, a, 1);
                }
            }
            else if (has2group(group))
            {
                int a = 0; int b = 0;
                get2group(group, out a, out b);
                if (group[a] == 1)
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", b, group[b]);
                    pickball(group, b, group[b]);
                }
                else if (group[b] == 1)
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", a, group[a]);
                    pickball(group, a, group[a]);
                }
                else if (group[a] > group[b])
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", a, group[a] - group[b]);
                    pickball(group, a, group[a] - group[b]);
                }
                else if (group[b] > group[a])
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", b, group[b] - group[a]);
                    pickball(group, b, group[b] - group[a]);
                }
                else
                {
                    pickball(group, a, 1);
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", a, 1);
                }
            }
            else
            {

                int a = 0; int b = 0; int c = 0;
                get3group(group, out a, out b, out c);
                #region chọn theo thứ tự 1,2,3

                #endregion

                #region vị trị 1,1,1
                if (group[a] == 1 && group[b] == 1 && group[c] > 1)
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", c, group[c] - 1);
                    pickball(group, c, group[c] - 1);
                }
                else if (group[a] == 1 && group[b] > 1 && group[c] == 1)
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", b, group[b] - 1);
                    pickball(group, b, group[b] - 1);
                }
                else if (group[a] > 1 && group[b] == 1 && group[c] == 1)
                {
                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", a, group[a] - 1);
                    pickball(group, a, group[a] - 1);
                }
                #endregion
                else
                {
                    int game1 = 0;
                    int game2 = 0;
                    if (group[3] >= group[2] && group[3] >= group[1]) game1 = 3;
                    else if (group[2] >= group[1] && group[2] >= group[3]) game1 = 2;
                    else if (group[1] >= group[2] && group[1] >= group[3]) game1 = 1;

                    if (group[3] <= group[2] && group[3] <= group[1]) game2 = 3;
                    else if (group[2] <= group[1] && group[2] <= group[3]) game2 = 2;
                    else if (group[1] <= group[2] && group[1] <= group[3]) game2 = 1;

                    Random rd = new Random();
                    Random rd2 = new Random();
                    int balls = 0;
                    if (group[1] != 1 && group[2] != 1 && group[3] != 1)
                        balls = rd.Next(1, group[game1]);
                    else if (group[1] == 3 && group[2] == 3 && group[3] == 3)
                    {
                        Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", 1, group[1]);
                        pickball(group, 1, group[1]);
                        prinfgame(group);
                        return;
                    }
                    for (int i = 1; i < group.Length; i++)
                    {
                        for (int j = 1; j < group[i]; j++)
                        {
                            if (group[a] + group[b] + group[c] - j == 12)
                            {
                                Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", i, j);
                                pickball(group, i, j);
                                prinfgame(group);
                                return;
                            }
                            else if (group[a] + group[b] + group[c] - j == 6 && (group[a] - j != group[b] && group[a] - j != group[c] && group[b] - j != group[c] && group[b] - j != group[a] && group[c] - j != group[a] && group[c] - j != group[b]))
                            {
                                Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", i, j);
                                pickball(group, i, j);
                                prinfgame(group);
                                return;
                            }
                        }
                    }
                    if (game1 == 1)
                    {
                        while (((group[game1] - (group[2] + balls) == 0) || (group[game1] - (group[3] + balls) == 0)) && ((group[game1] + group[2] + group[3] - balls == 7) || (group[game1] + group[2] + group[3] - balls == 9)))
                        {
                            balls = rd.Next(1, group[game1]);
                        }
                        #region nếu 1 lớn nhất
                        if (group[2] > group[3] && ((group[3] == 1 && group[2] == 3) || (group[3] == 2 && group[1] == 3) || (group[3] == 1 && group[1] == 2)))
                        {
                            Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                            pickball(group, game1, 1);
                            prinfgame(group);
                            return;
                        }
                        else if (group[3] > group[2] && ((group[2] == 1 && group[3] == 3) || (group[2] == 2 && group[3] == 3) || (group[2] == 1 && group[3] == 2)))
                        {
                            int s = 1;
                            if (group[2] == 1 && group[3] == 3) s = group[game1 - 2];
                            else if (group[2] == 2 && group[3] == 3) s = group[game1 - 1];
                            else if (group[3] == 1 && group[3] == 2) s = group[game1 - 3];
                            Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, s);
                            pickball(group, game1, s);
                            prinfgame(group);
                            return;
                        }
                        else
                        {
                            rd2.Next(1, 2);
                            if (rd2.Next(1, 4) == 3)
                            {
                                Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                                pickball(group, game1, 1);
                            }
                            else
                            {
                                Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                                pickball(group, game1, group[game1]);
                            }
                            prinfgame(group);
                            return;
                        }
                        #endregion
                    }
                    else if (game1 == 2)
                    {
                        while (((group[game1] - (group[1] + balls) == 0) || (group[game1] - (group[3] + balls) == 0)) && ((group[1] + group[game1] + group[3] - balls == 7)))
                        {
                            balls = rd.Next(1, group[game1]);
                        }
                        #region nếu 2 lớn nhất
                        if (group[1] > group[3] && ((group[3] == 1 && group[1] >= 3) || (group[3] == 2 && group[1] == 3) || (group[3] == 1 && group[1] == 2)))
                        {
                            Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                            pickball(group, game1, 1);
                            prinfgame(group);
                            return;
                        }
                        else if (group[3] > group[1] && ((group[1] == 1 && group[3] >= 3) || (group[1] == 2 && group[3] == 3) || (group[1] == 1 && group[3] == 2)))
                        {
                            int s = 1;
                            if (group[1] == 1 && group[3] == 3) s = group[game1 - 2];
                            else if (group[1] == 2 && group[3] == 3) s = group[game1 - 1];
                            else if (group[1] == 1 && group[3] == 2) s = group[game1 - 3];
                            Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, s);
                            pickball(group, game1, s);
                            prinfgame(group);
                            return;
                        }
                        else
                        {
                            rd2.Next(1, 2);
                            if (rd2.Next(1, 4) == 3)
                            {
                                Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                                pickball(group, game1, 1);
                            }
                            else
                            {
                                Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                                pickball(group, game1, group[game1]);
                            }
                            prinfgame(group);
                            return;
                        }
                        #endregion
                    }
                    else if (game1 == 3)
                    {
                        while (((group[game1] - (group[2] + balls) == 0) || (group[game1] - (group[3] + balls) == 0)) && ((group[1] + group[2] + group[game1] - balls == 7) || (group[1] + group[2] + group[game1] - balls == 9)))
                        {
                            balls = rd.Next(1, group[game1]);
                        }
                        #region nếu 3 lớn nhất
                        if (group[1] > group[2] && ((group[2] == 1 && group[1] >= 3) || (group[2] == 2 && group[1] == 3) || (group[2] == 1 && group[1] == 2)))
                        {
                            Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                            pickball(group, game1, 1);
                            prinfgame(group);
                            return;
                        }
                        else if (group[2] > group[1] && ((group[1] == 1 && group[2] >= 3) || (group[1] == 2 && group[2] == 3) || (group[1] == 1 && group[2] == 2)))
                        {
                            int s = 1;
                            if (group[1] == 1 && group[2] == 3) s = group[game1 - 2];
                            else if (group[1] == 2 && group[2] == 3) s = group[game1 - 1];
                            else if (group[1] == 1 && group[2] == 2) s = group[game1 - 3];
                            Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, s);
                            pickball(group, game1, s);
                            prinfgame(group);
                            return;
                        }
                        else
                        {
                            rd2.Next(1, 2);
                            if (rd2.Next(1, 4) == 3)
                            {
                                Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                                pickball(group, game1, 1);
                            }
                            else
                            {
                                Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, 1);
                                pickball(group, game1, group[game1]);
                            }
                            prinfgame(group);
                            return;
                        }
                        #endregion
                    }
                    else if (group[1] == 1 && group[2] == 1 && group[3] == 1)
                    {
                        Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", 1, 1);
                        pickball(group, 1, 1);
                        prinfgame(group);
                        return;
                    }
                    else if (game2 == 1 && group[2] == group[3])
                    {
                        Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} `viên", game2, 1);
                        pickball(group, game2, 1);
                        prinfgame(group);
                        return;
                    }
                    else if (game2 == 2 && group[1] == group[3])
                    {
                        Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game2, 1);
                        pickball(group, game2, 1);
                        prinfgame(group);
                        return;
                    }
                    else if (game2 == 3 && group[2] == group[1])
                    {
                        Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game2, 1);
                        pickball(group, game2, 1);
                        prinfgame(group);
                        return;
                    }

                    Console.WriteLine("lựa chọn của máy là nhóm {0}, {1} viên", game1, balls);
                    pickball(group, game1, balls);
                }
            }
            prinfgame(group);
        }
        #endregion
    }
}
