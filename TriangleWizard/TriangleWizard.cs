using System;
using System.Collections.Generic;
using System.Linq;

namespace TriangleWiz
{
    public class TriangleWizard
    {
        public TriangleWizard()
        {
            container1 = new List<Tuple<int, List<int>>>();
            container2 = new List<Tuple<int, List<int>>>();
            sumlist = new List<int>();
        }
 
        public (int, List<int>) CalculatePath(List<List<int>> bruttolist)
        {
            container1.Add(new Tuple<int, List<int>> (0, bruttolist[0]));
            if (IsOdd(bruttolist[0][0]))
            {
                StartsOdd(bruttolist);
            }
            else 
            {
                //StartsEven(bruttolist);
                //Console.WriteLine("Fail");
            }
            List<List<int>> allpaths = AccessPaths(bruttolist); 
            (int count, int sum) = HighestSum(allpaths);
            return (sum, allpaths[count]);
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public void StartsOdd(List<List<int>> bruttolist)
        {
            int size = bruttolist.Count;
            for (int i = 1; i < size; i++)
            {
                if (i % 2 == 1)
                {
                    container2.Clear();
                    foreach (Tuple<int, List<int>> tub1 in container1)
                    {
                        for (int j = tub1.Item1; j < tub1.Item1 + 2; j++)
                        {
                            if (IsOdd(bruttolist[i][j]))
                            {
                            }
                            else
                            {
                                List<int> templist1 = new List<int>(tub1.Item2);
                                templist1.Add(bruttolist[i][j]);
                                container2.Add(new Tuple<int, List<int>> (j, templist1));
                            }
                        }
                    }
                }
                else
                {
                    container1.Clear();
                    foreach (Tuple<int, List<int>> tub2 in container2)
                    {
                        for (int k = tub2.Item1; k < tub2.Item1 + 2; k++)
                        {
                            if (IsOdd(bruttolist[i][k]))
                            {
                                List<int> templist2 = new List<int>(tub2.Item2);
                                templist2.Add(bruttolist[i][k]);
                                container1.Add(new Tuple<int, List<int>>(k, templist2));
                            }
                            else
                            {
                            }
                        }
                    }
                }
            }
        }

        //public void StartsEven(List<List<int>> bruttolist)
        //{
        //    int size = bruttolist.Count;
        //    int count = 0;


        //}

        public List<List<int>> AccessPaths(List<List<int>> bruttolist)
        {
            int size = bruttolist.Count;
            List<List<int>> legalpaths = new List<List<int>>();
            if (IsOdd(size))
            {
                foreach (Tuple<int, List<int>> cont in container1)
                {
                    legalpaths.Add(cont.Item2);
                }
            }
            else
            {
                foreach (Tuple<int, List<int>> cont in container2)
                {
                    legalpaths.Add(cont.Item2);
                }
            }
            return legalpaths;
        }

        public (int, int) HighestSum(List<List<int>> listoflists)
        {
            foreach (List<int> sublist in listoflists)
            {
                int sumAf = sublist.Sum();
                sumlist.Add(sumAf);
            }
            int maxsum = sumlist.Max();
            int c = 0;
            for (int i = 0; sumlist[i] != maxsum; i++)
            {
                c ++;
            }
            return (c, maxsum);
        }

        public List<Tuple<int, List<int>>> container1;
        public List<Tuple<int, List<int>>> container2;
        public List<int> sumlist;
    }
}
