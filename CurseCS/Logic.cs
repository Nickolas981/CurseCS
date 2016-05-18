using System;

namespace CurseCS
{
    class Logic
    {
        private Drawble drawble;
        private readonly Random rand = new Random();
        public int[] mass;
        public  int[] sMass;
        private readonly int n;
        public Logic(int N , Drawble dr , int z)
        {
            drawble = dr;   
            n = N;
            mass = new int[n];
            sMass = new int[n];
            for (var i = 0; i < n; i++)
            {
                mass[i] = rand.Next(z)+1;
                sMass[i] = mass[i];
            }
        }
        public int[] GetMass()
        {
            return mass;
        }
        public int GetSize()
        {
            return n;
        }
        public int[] GetOrgMass()
        {
            return sMass;
        }
        public int[] MethodZlit(ref int counterIF, ref int counterSWAP)
        {
            MetZlit(0, n-1, ref counterIF, ref counterSWAP);
            return mass;
        }
        public int[] MethodShella(ref int counterIF, ref int counterSWAP)
        {
            MetShella(ref counterIF, ref counterSWAP);
            return mass;
        }
        public int[] SpeedMethod(ref int counterIF, ref int counterSWAP)
        {
            SpeedMet(0,n-1,ref counterIF,ref counterSWAP);
            return mass;
        }
        private static void Swap(ref int left, ref int right)
        {
            int t = left;
            left = right;
            right = t;
        }
        private void MetZlit(int left, int right, ref int counterIF, ref int counterSWAP)
        {
            counterIF++;
            if (right == left)
                return;
            counterIF++;
            if (right - left == 1)
            {
                counterIF++;
                if (mass[right] < mass[left])
                {
                    counterSWAP++;
                    Swap(ref mass[right], ref mass[left]);
                }
                return;
            }
            var medium = (right + left) / 2;
            MetZlit(left, medium, ref  counterIF, ref  counterSWAP);
            MetZlit(medium + 1, right, ref  counterIF, ref counterSWAP);
            var buf = new int[n];
            var xl = left;
            var xr = medium + 1;
            var cur = 0;
            while (right - left + 1 != cur)
            {
                counterSWAP++;
                counterIF += 4;
                if (xl > medium)                
                    buf[cur++] = mass[xr++];                
                else if (xr > right)
                    buf[cur++] = mass[xl++];                
                else if (mass[xl] > mass[xr])
                    buf[cur++] = mass[xr++];                
                else buf[cur++] = mass[xl++];

            }
            for (var i = 0; i < cur; i++)
            {
                counterSWAP++;
                mass[i + left] = buf[i];
            }
        }
        private void MetShella(ref int counterIF, ref int counterSWAP)
        {
            int i, j, k;
            int t;
            for (k = n / 2; k > 0; k /= 2)
                for (i = k; i < n; i += 1)
                {
                    counterSWAP++;
                    t = mass[i];
                    for (j = i; j >= k; j -= k)
                    {
                        counterIF++;
                        if (t < mass[j - k])
                        {
                            counterSWAP++;
                            mass[j] = mass[j - k];
                        }
                        else
                            break;
                    }
                    counterSWAP++;
                    mass[j] = t;
                }
        }
        private void SpeedMet(int first, int last, ref int counterIF, ref int counterSWAP)
        {
            int i = first, j = last, x = mass[(first + last) / 2];

            do
            {
                while (mass[i] < x)
                {
                    counterIF++;
                    i++;
                }
                while (mass[j] > x) {
                    counterIF++;
                    j--;
                }
                counterIF++;
                if (i > j) {
                    continue;
                }
                counterIF++;
                if (mass[i] > mass[j]) {
                    counterSWAP++;
                    Swap(ref mass[i], ref mass[j]);
                }                
                i++;
                j--;
                counterIF++;
            } while (i <= j);
            counterIF++;
            if (i < last)            
              SpeedMet(i, last, ref counterIF, ref counterSWAP);            
            counterIF++;
            if (first < j)            
              SpeedMet(first, j, ref counterIF, ref counterSWAP);
            
        }
        public void MetZlitD(int Left, int Right)
        {

            if (Right == Left)
            {
                drawble.Draw();
                return;
            }

            if (Right - Left == 1)
            {
                if (sMass[Right] < sMass[Left])
                {
                    Swap(ref sMass[Right], ref sMass[Left]);
                }
                drawble.Draw();
                return;
            }
            int medium = (Right + Left) / 2;
            MetZlitD(Left, medium);
            MetZlitD(medium + 1, Right);
            int[] buf = new int[n];
            int xl = Left;
            int xr = medium + 1;
            int cur = 0;
            while (Right - Left + 1 != cur)
            {
                if (xl > medium)
                    buf[cur++] = sMass[xr++];
                else if (xr > Right)
                    buf[cur++] = sMass[xl++];
                else if (sMass[xl] > sMass[xr])
                    buf[cur++] = sMass[xr++];
                else buf[cur++] = sMass[xl++];

            }
            for (int i = 0; i < cur; i++)
                sMass[i + Left] = buf[i];
            drawble.Draw();
        }
        public void MetShellaD()
        {
            int i, j, k;
            int t;
            for (k = n / 2; k > 0; k /= 2)
                for (i = k; i < n; i += 1)
                {
                    t = sMass[i];
                    for (j = i; j >= k; j -= k)
                    {
                        if (t < sMass[j - k])
                        {
                            sMass[j] = sMass[j - k];
                            drawble.Draw();
                        }
                        else
                            break;
                    }
                    sMass[j] = t;
                }
        }
        public void SpeedMetD(int first, int last)
        {
            int i = first, j = last, x = sMass[(first + last) / 2];

            do
            {
                while (sMass[i] < x) i++;
                while (sMass[j] > x) j--;

                if (i <= j)
                {
                    if (sMass[i] > sMass[j]) Swap(ref sMass[i], ref sMass[j]);
                    drawble.Draw();
                    i++;
                    j--;
                }
            } while (i <= j);

            if (i < last)
                SpeedMetD(i, last);
            if (first < j)
                SpeedMetD(first, j);
        }
    }

}
