using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_Detyra1_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> A;
        int k;
        int AvgWorkLoad;
        Dictionary<int, int[]> Solution;
        int[] Times;

        private void button1_Click(object sender, EventArgs e)
        {
            A = new List<int> { 100, 200, 300, 400, 500, 600, 700, 800, 900 };
            //A = RandomArray();
            k = (int)nupNrPainters.Value;
            if (k > A.Count) k = A.Count;

            AvgWorkLoad = CalculateAvgWork();
            Solution = new Dictionary<int, int[]>();
            Times = new int[k];

            string strRez = "";
            // String Formatting for Printing Input
            strRez += "\nInputs:\nTables to paint are: {";
            foreach (var item in A)
                strRez += " " + item + " ";
            strRez += " }\nNumber of painters is: " + k.ToString();

            // Actual Partition Workload
            WorkPartition(A);

            // String Formatting for Printing Result
            strRez += "\n\nResult:\nMinimum time to paint: " + Times.Max();
            strRez += "\n\nSolution: ";
            int l = 1;
            foreach (var s in Solution)
            {
                strRez += "\nPainter" + l.ToString() + ":  ";
                foreach (var sol in s.Value)
                    strRez += " " + sol.ToString() + " ";
                l++;
            }
            rtbRez.Text = strRez;
        }
        
        private void WorkPartition(List<int> A)
        {
            if (k == 0 || A.Count == 0)
                return;

            int sum = 0, prevSum;
            for (int j = 0; j < A.Count; j++)
            {
                prevSum = sum;
                sum += A[j];

                if (sum >= AvgWorkLoad)
                {
                    // prevSum ---d1--- avgWorkLoad ----d2--- sum
                    int d1 = Math.Abs(AvgWorkLoad - prevSum);
                    int d2 = Math.Abs(sum - AvgWorkLoad);
                    if (d1 <= d2)
                    {
                        Solution.Add(k--, (int[])A.GetRange(0, j).ToArray());
                        A.RemoveRange(0, j);
                        Times[k] = prevSum;
                    }
                    else if (d2 < d1)
                    {
                        Solution.Add(k--, (int[])A.GetRange(0, j + 1).ToArray());
                        A.RemoveRange(0, j + 1);
                        Times[k] = sum;
                    }
                    WorkPartition(A);
                    return;
                }
                else
                {
                    if (j + 1 == A.Count) // Last iteration
                    {
                        Solution.Add(k--, (int[])A.ToArray());
                        Times[k] = sum;
                        return;
                    }
                }
            }
        }

        private int CalculateAvgWork()
        {
            int sum = 0;
            for (int i = 0; i < A.Count; i++)
                sum += A[i];
            return (sum / k);
        }

        private List<int> RandomArray()
        {
            List<int> r = new List<int>();
            Random rand = new Random(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).Millisecond);
            for (int i = 0; i < 10; i++)
                r.Add(rand.Next(1, 9) * 10);
            return r;
        }
    }
}
