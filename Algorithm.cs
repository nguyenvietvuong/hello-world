using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Collections;

namespace KM_Cshaft.BaseClass
{
    class Algorithm
    {
        public struct FileOpenType {
            public String Filename;
            public DateTime DateTime;
        }
        public struct couplertypeV1 {
            public int value_;
            public int index_;
            public bool outrange;
        }
        public struct TimeresultV1 {
            public DateTime Time_;
            public bool outrange;
        }
    public enum DataEditType {
            normalString = 0,
        normalIntegerString = 1,
        normalDecimalString = 2,
        normalDateTimeString = 3,
        normalCurrencyString = 4,
        NullValue = 5
    }
        public String resourseperate = "$x$x$";
        public String rsnamesep = "*:*";
        private FolderAndFile FF = new FolderAndFile();
        //function will return DataEditType from a truely string
        public DataEditType GetDataEditType(String Strin) {
            Decimal x = 0;
            if (Strin.Trim() == "") {
                return DataEditType.NullValue;
            }
            else {
                if (Decimal.TryParse(Strin, out x) == true) {
                    if (x.ToString() == Strin) {
                        return DataEditType.normalDecimalString;
                    }
                    else {
                        return DataEditType.normalString;
                    }
                }
                else {
                    return DataEditType.normalString;
                }
            }
        }
        //This function will sorting an array of Long value with Fisrt Index define by First, And LastIndex defined by Last Parameter
    public void QuickSort(ref long[] Arrin, long First, long Last, bool decending = false) {
            //
            //  Made by Michael Ciurescu (CVMichael from vbforums.com)
            //  Original thread: [url]http://www.vbforums.com/showthread.php?t=231925[/url]
            //Convert to C# Language by Nguyen Viet Vuong 1/8/2019
            long Low;
            long High;
            long MidValue;

            Low = First;
            High = Last;
            //long index = (First + Last)/2;
            if (First > Last) { return; }
            MidValue = Arrin[(First + Last) / 2];
            do {
                if (decending == false){
                    while (Arrin[Low] < MidValue) {
                        Low = Low + 1;
                    }

                    while (Arrin[High] > MidValue) {
                        High = High - 1;
                    }
                }
                else {
                    while (Arrin[Low] > MidValue) {
                        Low = Low + 1;
                    }

                    while (Arrin[High] < MidValue) {
                        High = High - 1;
                    }

                }

                if (Low <= High) {
                    Swap(ref Arrin[Low], ref Arrin[High]);
                    Low = Low + 1;
                    High = High - 1;
                }
            } while (Low <= High);
            if (First < High) { QuickSort(ref Arrin, First, High, decending); }
            if (Low < Last) { QuickSort(ref Arrin, Low, Last, decending); }
        }
    public void QuickSort(ref DateTime[] Arrin, long First, long Last, bool decending = false)
        {
            //,
            //  Made by Michael Ciurescu (CVMichael from vbforums.com)
            //  Original thread: [url]http://www.vbforums.com/showthread.php?t=231925[/url]
            //  Adding accending and Decending Optional
            long Low;
            long High;
            DateTime MidValue;

            Low = First;
            High = Last;
            if (First > Last) { return; }
            MidValue = Arrin[(First + Last) / 2];
            do
            {
                if (decending == false)
                {
                    while (Arrin[Low] < MidValue)
                    {
                        Low = Low + 1;
                    }

                    while (Arrin[High] > MidValue)
                    {
                        High = High - 1;
                    }
                }
                else
                {
                    while (Arrin[Low] > MidValue)
                    {
                        Low = Low + 1;
                    }

                    while (Arrin[High] < MidValue)
                    {
                        High = High - 1;
                    }

                }

                if (Low <= High)
                {
                    Swap(ref Arrin[Low], ref Arrin[High]);
                    Low = Low + 1;
                    High = High - 1;
                }
            } while (Low <= High);

            if (First < High) { QuickSort(Arrin, First, High, decending); }
            if (Low < Last) { QuickSort(Arrin, Low, Last, decending); }
        }
    public void QuickSort(ref couplertypeV1[] Arrin, long First, long Last, bool decending = false)
        {
            //,
            //  Made by Michael Ciurescu (CVMichael from vbforums.com)
            //  Original thread: [url]http://www.vbforums.com/showthread.php?t=231925[/url]
            //  Adding accending and Decending Optional
            long Low;
            long High;
            int MidValue;

            Low = First;
            High = Last;
            if (First > Last) { return; }
            MidValue = Arrin[(First + Last) / 2].value_;
            do
            {
                if (decending == false)
                {
                    while (Arrin[Low].value_ < MidValue)
                    {
                        Low = Low + 1;
                    }

                    while (Arrin[High].value_ > MidValue)
                    {
                        High = High - 1;
                    }
                }
                else
                {
                    while (Arrin[Low].value_ > MidValue)
                    {
                        Low = Low + 1;
                    }

                    while (Arrin[High].value_ < MidValue)
                    {
                        High = High - 1;
                    }

                }

                if (Low <= High)
                {
                    Swap(ref Arrin[Low], ref Arrin[High]);
                    Low = Low + 1;
                    High = High - 1;
                }
            } while (Low <= High);

            if (First < High) { QuickSort(Arrin, First, High, decending); }
            if (Low < Last) { QuickSort(Arrin, Low, Last, decending); }
        }
    public void QuickSort(ref FileOpenType[] Arrin, long First, long Last, bool decending = false)
        {
            //,
            //  Made by Michael Ciurescu (CVMichael from vbforums.com)
            //  Original thread: [url]http://www.vbforums.com/showthread.php?t=231925[/url]
            //  Adding accending and Decending Optional
            long Low;
            long High;
            DateTime MidValue;

            Low = First;
            High = Last;
            if (First > Last) { return; }
            MidValue = Arrin[(First + Last) / 2].DateTime;
            do
            {
                if (decending == false)
                {
                    while (Arrin[Low].DateTime < MidValue)
                    {
                        Low = Low + 1;
                    }

                    while (Arrin[High].DateTime > MidValue)
                    {
                        High = High - 1;
                    }
                }
                else
                {
                    while (Arrin[Low].DateTime > MidValue)
                    {
                        Low = Low + 1;
                    }

                    while (Arrin[High].DateTime < MidValue)
                    {
                        High = High - 1;
                    }

                }

                if (Low <= High)
                {
                    Swap(ref Arrin[Low], ref Arrin[High]);
                    Low = Low + 1;
                    High = High - 1;
                }
            } while (Low <= High);

            if (First < High) { QuickSort(Arrin, First, High, decending); }
            if (Low < Last) { QuickSort(Arrin, Low, Last, decending); }
        }
    public long findnextindexfromArrlong(long[] arrlong_)
        {
            long result = 1;
            long BreakIndex;
            long[] arrlong;
            arrlong = arrlong_;
            QuickSort(ref arrlong, 1, arrlong.GetUpperBound(0), false);
            //AL.QuickSort(arrlong, 1, UBound(arrlong))
            long i;
            if (arrlong.GetUpperBound(0) == 0) { result = 1; }
            if (arrlong.GetUpperBound(0) == 1)
            {
                if (arrlong[1] == 1)
                {
                    result = 2;
                }
                else
                {
                    result = 1;
                }
            }
            if (arrlong.GetUpperBound(0) > 1)
            {
                for (i = 0; i <= arrlong.GetUpperBound(0) - 1; i++)
                {
                    BreakIndex = i;
                    if (arrlong[i] < arrlong[i + 1] - 1)
                    {
                        result = arrlong[i] + 1;
                        break;
                    }
                }
                result = arrlong[arrlong.GetUpperBound(0)] + 1; //IF all the members icreasing 1 or equal
            }
            return result;
        }
        private void Swap(ref long A, ref long B) {
            long T;
            T = A;
            A = B;
            B = T;
            }
        private void Swap(ref String A, ref String B) {
            String T;
            T = A;
            A = B;
            B = T;
        }
        private void Swap(ref DateTime A, ref DateTime B)
        {
            DateTime T;
            T = A;
            A = B;
            B = T;
        }
        private void Swap(ref couplertypeV1 A, ref couplertypeV1 B)
        {
            couplertypeV1 T;
            T = A;
            A = B;
            B = T;
        }
        private void Swap(ref FileOpenType A, ref FileOpenType B)
        {
            FileOpenType T;
            T = A;
            A = B;
            B = T;
        }
       
        public long GetLongvalueFromNodename(String nodename)
        {
            String numstr = Numberstringextraction(nodename);
            if (numstr == "")
            {
                return 0;
            }
            else
            {
                return stringtolong(numstr);
            }
        }
        public String Numberstringextraction(String inputstr, bool leftright = false)
        {
            int i = 0;
            String res;
            res = "";

            for (i = inputstr.Length; i >= 0; i--)
            {
                if (checkstrNumber(inputstr.Substring(i, 1)) == true)
                {//checkstrNumber(Mid(inputstr, i, 1)) = True Then
                    if (leftright == false)
                    {
                        res = inputstr.Substring(i, 1) + res;
                    }
                    else
                    {
                        res = res + inputstr.Substring(i, 1);
                    }

                }
                else
                {
                    break;
                }
            }
            return res;
        }
        public bool checkstrNumber(String str)
        {
            if (ASC(str) >= ASC("0") && ASC(str) <= ASC("9"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ASC(String str)
        {
            return (int)str.ToCharArray()[0];
        }
        public long stringtolong(String str)
        {
            long rs = 0;
            try
            {
                rs = (long)Convert.ToDouble(str);
            }catch(Exception ex)
            {
                rs = 0;
            }
            return rs;

        }
        //redim an T array keep its old value and resize it dimension
        public  void redim<T>(ref T[,] arr , int ubound1, int ubound2) 
        {
            T[,] temp = new T[0, 0];
            if (arr == null || arr.GetUpperBound(0) < 0 || arr.GetUpperBound(1) <0)
            {
                arr = new T[ubound1+1, ubound2+1];
            }
            else
            {
                if (arr.GetUpperBound(0) <ubound1 && arr.GetUpperBound(1) < ubound2)
                {
                    temp = new T[arr.GetUpperBound(0)+1, arr.GetUpperBound(1)+1];
                    tranferarr<T>(ref temp, arr, temp.GetUpperBound(0), temp.GetUpperBound(1));
                    arr = new T[ubound1+1, ubound2+1];
                    tranferarr<T>(ref arr, temp, temp.GetUpperBound(0), temp.GetUpperBound(1));
                }
                else
                {
                    if (arr.GetUpperBound(0) < ubound1 && arr.GetUpperBound(1) >= ubound2)
                    {
                        temp = new T[arr.GetUpperBound(0)+1, ubound2+1];
                        tranferarr<T>(ref temp, arr, temp.GetUpperBound(0), temp.GetUpperBound(1));
                        arr = new T[ubound1+1, ubound2+1];
                        tranferarr<T>(ref arr, temp, temp.GetUpperBound(0), temp.GetUpperBound(1));
                    }
                    else
                    {
                        if (arr.GetUpperBound(0) >= ubound1 && arr.GetUpperBound(1) < ubound2)
                        {
                            temp = new T[ubound1+1, arr.GetUpperBound(1)+1];
                            tranferarr<T>(ref temp, arr, temp.GetUpperBound(0), temp.GetUpperBound(1));
                            arr = new T[ubound1+1, ubound2+1];
                            tranferarr<T>(ref arr, temp, temp.GetUpperBound(0), temp.GetUpperBound(1));

                        }
                        else
                        {
                            if (arr.GetUpperBound(0) >= ubound1 && arr.GetUpperBound(1) >= ubound2)
                            {
                                temp = new T[ubound1+1, ubound2+1];
                                tranferarr<T>(ref temp, arr, temp.GetUpperBound(0), temp.GetUpperBound(1));
                                arr = new T[ubound1+1, ubound2+1];
                                tranferarr<T>(ref arr, temp, temp.GetUpperBound(0), temp.GetUpperBound(1));

                            }
                        }
                    }
                }
            }

        }
        public void redim<T>(ref T[]arr, int ubound)
        {
            T[] temp;
            if(arr==null || arr.GetUpperBound(0) < 0)
            {
                arr = new T[ubound + 1];
            }
            else
            {
                if(arr.GetUpperBound(0) < ubound)
                {
                    temp = new T[arr.GetUpperBound(0) + 1];
                    tranferarr<T>(ref temp, arr, temp.GetUpperBound(0));
                    arr = new T[ubound + 1];
                    tranferarr<T>(ref arr, temp, temp.GetUpperBound(0));
                }
                else
                {
                    if (arr.GetUpperBound(0) >= ubound)
                    {
                        temp = new T[ubound + 1];
                        tranferarr<T>(ref temp, arr, temp.GetUpperBound(0));
                        arr = new T[ubound + 1];
                        tranferarr<T>(ref arr, temp, temp.GetUpperBound(0));
                    }
                }
            }
        }
        private void tranferarr<T>(ref T[,]desarr, T[,] source, int row, int col)
        {
            int i;
            int j;
            for(i = 0; i <= row; i++)
            {
                for (j = 0; j <= col; j++)
                {
                    desarr[i, j] = source[i, j];
                }
            }
        }
        private void tranferarr<T>(ref T[] desarr, T[] source, int index)
        {
            int i;
            for (i = 0; i <= index; i++)
            {
                desarr[i] = source[i];
            }
        }

        //function concept: eg inputstring = "ffwe123fs45678" the result will be "ffwe123fs"
        public String NameStringExtraction(String inputstr)
        {
            String numberstring = Numberstringextraction(inputstr);
            return inputstr.Substring(0, inputstr.Length - numberstring.Length);
        }

        public String increaseextensioncode(String previousstring) {
            long longstring = stringtolong(previousstring);
            long longres = longstring + 1;
            return formatnumberstring(longres.ToString(), 7);
        }
        //this function will format a string number to xxxxx-predefine leng 
        public String formatnumberstring(String numbrestr, long sLenth)
        {
            int i;
            String res;
            res = "";
            for (i = 0; i <= sLenth; i++)
            {
                if (i <= numbrestr.Length)
                {
                    res = res + numbrestr.Substring(i, 1);
                }
                else
                {
                    res = "0" + res;
                }
            }
            return res;
        }
        //F1changeCodeVersion2
        //F2changeCodeVersion2
        //codeF1F2Version2
        //decodeF1F2version2
        public bool GetBoolFromStr(String instr_)
        {
            if (instr_.ToLower() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime GetDateFromStr(String Instr_) {
            return DateTime.FromOADate(ConvertValidDoubleString_(Instr_));
        }
        public String ConvertValidDoubleString(String dbstringin) {
            if (dbstringin.Trim().Length <= 0) { return "0"; }
            String sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            String tg = dbstringin.Replace(",", sep);
            String tg2 = tg.Replace(".", sep);
            String tg3 = tg.Replace("'", sep);
            return tg3;
        }
        public double ConvertValidDoubleString_(String dbstringin)
        {
            if (dbstringin.Trim().Length <= 0) { return 0; }
            String sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            String tg = dbstringin.Replace(",", sep);
            String tg2 = tg.Replace(".", sep);
            String tg3 = tg.Replace("'", sep);
            return Convert.ToDouble(tg3);
        }
        public int IntCon(String instr_)
        {
            if (IsInt(instr_) == false)
            {
                return 0;
            }
            else
            {
                return (int)Convert.ToDouble(instr_);
            }
        }
        public bool IsInt(Object value) {
            int i = 0;
            return int.TryParse(Convert.ToString(value), out i);
        }


        //endcode and decode function 
        public String codeF1F2Version2(String strin) {
            String tem1;
            String res;
            //1 code F1F2 by codeF1F2
            tem1 = ChangeStringF1F2Version2(strin);
            // MsgBox(tem1)
            //1 code position by CodePosition2Level
            res = CodePosition2Level(tem1);
            return res;
        }
        private String CodePosition2Level(String strin) {
            String res;
            res = MixpositionF2(MixpositionF1(strin));
            return res;
        }
        //Mix function level (i): F1 <-> level 1 index = 1,
        //Mix function level (i): F2 <-> level 2 index = 2,
        //....<-> level i index = i,
        private String MixpositionF1(String strin) {
            String res;
            long index;
            String tempstr;
            tempstr = strin;
            index = 1;
            while (index + 1 <= strin.Length) {
                tempstr = changeovercharacterbyindex(tempstr, index, index + 1);
                index = index + 2;
            }
            res = tempstr;
            return res;
        }
        private String MixpositionF2(String strin) {
            String res;
            long index;
            String tempstr;
            tempstr = strin;
            index = 2;
            while (index + 1 <= strin.Length) {
                tempstr = changeovercharacterbyindex(tempstr, index, index + 1);
                index = index + 2;
            }
            res = tempstr;
            return res;
        }
        //this function changover leter have pos index1 and index2 of input string
        private String changeovercharacterbyindex(String strin, long index1, long index2) {
            String res;
            String string1;
            String string2;
            String string3;
            long smallindex;
            long greaterindex;
            String char1;
            String char2;
            char1 = strin.Substring((int)index1, 1);
            char2 = strin.Substring((int)index2, 1);
            if (index1 > index2) {
                smallindex = index2;
                greaterindex = index1;
                // = string1 + char1 + string2 + char2 + string3
                string1 = strin.Substring(0, (int)smallindex - 1);
                string2 = strin.Substring((int)smallindex + 1, (int)greaterindex - (int)smallindex - 1);
                string3 = strin.Substring((int)greaterindex + 1, strin.Length - (int)greaterindex);
                res = string1 + char1 + string2 + char2 + string3;
            }
            else {
                if (index2 > index1) {
                    smallindex = index1;
                    greaterindex = index2;
                    // = string1 + char2 + string2 + char1 + string3
                    string1 = strin.Substring(0, (int)smallindex - 1);
                    string2 = strin.Substring((int)smallindex + 1, (int)greaterindex - (int)smallindex - 1);
                    string3 = strin.Substring((int)greaterindex + 1, strin.Length - (int)greaterindex);
                    res = string1 + char2 + string2 + char1 + string3;
                }
                else {
                    //= Strin
                    res = strin;
                }
            }
            return res;
        }
        private String ChangeStringF1F2Version2(String StringIn) {
            String res_ = "";
            // res = ""
            int i;
            for (i = 0; i <= StringIn.Length - 1; i++) {
                res_ = res_ + (char)(F2changeCodeVersion2(F1changeCodeVersion2(ASC(StringIn.Substring(i, 1)))));
                // MsgBox(Mid(StringIn, i, 1) & "  " & Asc(Mid(StringIn, i, 1)) & "    " & Chr(F2changeCodeVersion2(F1changeCodeVersion2(Asc(Mid(StringIn, i, 1))))) & "  ---> " & res_)
            }
            //MsgBox(res)
            return res_; 
        }
        private long F1changeCodeVersion2(long codein) {
            long res;
            if (codein  == 48) { res = 51; }
            if (codein  == 49) { res = 54; }
            if (codein  == 50) { res = 65; }
            if (codein  == 52) { res = 56; }
            if (codein  == 53) { res = 68; }
            if (codein  == 55) { res = 70; }
            if (codein  == 57) { res = 69; }
            if (codein  == 66) { res = 74; }
            if (codein  == 67) { res = 75; }
            if (codein  == 71) { res = 79; }
            if (codein  == 72) { res = 80; }
            if (codein  == 73) { res = 81; }
            if (codein  == 76) { res = 84; }
            if (codein  == 77) { res = 87; }
            if (codein  == 78) { res = 89; }
            if (codein  == 82) { res = 97; }
            if (codein  == 83) { res = 86; }
            if (codein  == 85) { res = 99; }
            if (codein  == 88) { res = 103; }
            if (codein  == 90) { res = 104; }
            if (codein  == 98) { res = 102; }
            if (codein  == 100) { res = 110; }
            if (codein  == 101) { res = 111; }
            if (codein  == 105) { res = 108; }
            if (codein  == 106) { res = 113; }
            if (codein  == 107) { res = 117; }
            if (codein  == 109) { res = 115; }
            if (codein  == 112) { res = 121; }
            if (codein  == 114) { res = 118; }
            if (codein  == 116) { res = 122; }
            if (codein  == 119) { res = 120; }
            //vice versa
            if (codein  == 51) { res = 48; }
            if (codein  == 54) { res = 49; }
            if (codein  == 65) { res = 50; }
            if (codein  == 56) { res = 52; }
            if (codein  == 68) { res = 53; }
            if (codein  == 70) { res = 55; }
            if (codein  == 69) { res = 57; }
            if (codein  == 74) { res = 66; }
            if (codein  == 75) { res = 67; }
            if (codein  == 79) { res = 71; }
            if (codein  == 80) { res = 72; }
            if (codein  == 81) { res = 73; }
            if (codein  == 84) { res = 76; }
            if (codein  == 87) { res = 77; }
            if (codein  == 89) { res = 78; }
            if (codein  == 97) { res = 82; }
            if (codein  == 86) { res = 83; }
            if (codein  == 99) { res = 85; }
            if (codein  == 103) { res = 88; }
            if (codein  == 104) { res = 90; }
            if (codein  == 102) { res = 98; }
            if (codein  == 110) { res = 100; }
            if (codein  == 111) { res = 101; }
            if (codein  == 108) { res = 105; }
            if (codein  == 113) { res = 106; }
            if (codein  == 117) { res = 107; }
            if (codein  == 115) { res = 109; }
            if (codein  == 121) { res = 112; }
            if (codein  == 118) { res = 114; }
            if (codein  == 122) { res = 116; }
            if (codein  == 120) { res = 119; }
            return res; 

        }
        private long F2changeCodeVersion2(long codein) {
            long res = 0;
            if (codein == 48) { res = 108; }
            if (codein == 49) { res = 121; }
            if (codein == 50) { res = 78; }
            if (codein == 51) { res = 57; }
            if (codein == 52) { res = 111; }
            if (codein == 53) { res = 109; }
            if (codein == 54) { res = 119; }
            if (codein == 55) { res = 105; }
            if (codein == 56) { res = 101; }
            if (codein == 65) { res = 90; }
            if (codein == 66) { res = 103; }
            if (codein == 67) { res = 117; }
            if (codein == 68) { res = 120; }
            if (codein == 69) { res = 118; }
            if (codein == 70) { res = 115; }
            if (codein == 71) { res = 113; }
            if (codein == 72) { res = 112; }
            if (codein == 73) { res = 110; }
            if (codein == 74) { res = 114; }
            if (codein == 75) { res = 116; }
            if (codein == 76) { res = 87; }
            if (codein == 77) { res = 98; }
            if (codein == 79) { res = 106; }
            if (codein == 80) { res = 102; }
            if (codein == 81) { res = 89; }
            if (codein == 82) { res = 104; }
            if (codein == 83) { res = 99; }

            if (codein == 84) { res = 97; }
            if (codein == 85) { res = 100; }
            if (codein == 86) { res = 122; }
            if (codein == 88) { res = 107; }
            //vice versa; }
            if (codein == 108) { res = 48; }
            if (codein == 121) { res = 49; }
            if (codein == 78) { res = 50; }
            if (codein == 57) { res = 51; }
            if (codein == 111) { res = 52; }
            if (codein == 109) { res = 53; }
            if (codein == 119) { res = 54; }
            if (codein == 105) { res = 55; }
            if (codein == 101) { res = 56; }
            if (codein == 90) { res = 65; }
            if (codein == 103) { res = 66; }
            if (codein == 117) { res = 67; }
            if (codein == 120) { res = 68; }
            if (codein == 118) { res = 69; }
            if (codein == 115) { res = 70; }
            if (codein == 113) { res = 71; }
            if (codein == 112) { res = 72; }
            if (codein == 110) { res = 73; }
            if (codein == 114) { res = 74; }
            if (codein == 116) { res = 75; }
            if (codein == 87) { res = 76; }
            if (codein == 98) { res = 77; }
            if (codein == 106) { res = 79; }
            if (codein == 102) { res = 80; }
            if (codein == 89) { res = 81; }
            if (codein == 104) { res = 82; }
            if (codein == 99) { res = 83; }
            if (codein == 97) { res = 84; }
            if (codein == 100) { res = 85; }
            if (codein == 122) { res = 86; }
            if (codein == 107) { res = 88; }
            return res;
        }

        public String DecodeF1F2Version2(String strin)
        {
            String tem1;
            String res;
            //1 code F1F2 by ChangeStringF1F2
            tem1 = DecodeStringF1F2version2(strin);
            //1 code position by CodePosition2Level
            res = DecodePositionCode2Level(tem1);
            return res;
        }
        private String DecodeStringF1F2version2(String StringIn)
        {
            String res;
            res = "";
            int i;
            for (i = 0; i <= StringIn.Length; i++)
            {
                res = res + (char)(F1changeCodeVersion2(F2changeCodeVersion2(ASC(StringIn.Substring(i, 1)))));
            }
            return res;
        }
        private String DecodePositionCode2Level(String strin)
        {
            String res;
            res = MixpositionF1(MixpositionF2(strin));
            return res;
        }

        //get the chipset serial number
        public String SystemSerialNumber()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + "Win32_BaseBoard");
            ManagementObject share_ = null;
            foreach (ManagementObject share in searcher.Get())
            {
                if (share != null)
                {
                    share_ = share;
                    break;
                }
            }
            String processorID = "";
            foreach (PropertyData PC in share_.Properties)
            {
                if (PC.Name == "SerialNumber")
                {
                    switch (PC.Value.GetType().ToString())
                    {
                        case "System.String[]":
                            string[] str = (string[])PC.Value;

                            string str2 = "";
                            foreach (string st in str)
                                str2 += st + " ";

                            //item.SubItems.Add(str2);
                            processorID = str2;
                            break;
                        case "System.UInt16[]":
                            ushort[] shortData = (ushort[])PC.Value;


                            string tstr2 = "";
                            foreach (ushort st in shortData)
                                tstr2 += st.ToString() + " ";

                            //item.SubItems.Add(tstr2);
                            processorID = tstr2;
                            break;

                        default:
                            processorID = PC.Value.ToString();
                            break;
                    }
                }
            }
            return processorID;
        }

        public String CpuId()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + "Win32_Processor");
            ManagementObject share_ = null;
            foreach (ManagementObject share in searcher.Get())
            {
                if (share != null)
                {
                    share_ = share;
                    break;
                }
            }
            String processorID = "";
            foreach (PropertyData PC in share_.Properties)
            {
                if (PC.Name == "ProcessorId")
                {
                    switch (PC.Value.GetType().ToString())
                    {
                        case "System.String[]":
                            string[] str = (string[])PC.Value;

                            string str2 = "";
                            foreach (string st in str)
                                str2 += st + " ";

                            //item.SubItems.Add(str2);
                            processorID = str2;
                            break;
                        case "System.UInt16[]":
                            ushort[] shortData = (ushort[])PC.Value;


                            string tstr2 = "";
                            foreach (ushort st in shortData)
                                tstr2 += st.ToString() + " ";

                            //item.SubItems.Add(tstr2);
                            processorID = tstr2;
                            break;

                        default:
                            processorID = PC.Value.ToString();
                            break;
                    }
                }
            }
            return processorID;
        }


        //function will get the date of nextweekday
        public DateTime getdateofnextweekday(int weekday)
        {
            DateTime rs = DateTime.Now;
            int currweekday = ((int)rs.DayOfWeek);
            DateTime day0ofthisweek = rs.AddDays(-currweekday);
            DateTime day0ofnextweek = day0ofthisweek.AddDays(7);
            DateTime nextweekday = day0ofnextweek.AddDays((double)weekday);
            return nextweekday;
        }



          //function will get the date of nextmonthday
    public DateTime getdateofnextmonthday(int monthday)
        {
            DateTime rs = DateTime.Now;
            DateTime nextday = new DateTime(rs.Year, rs.Month, monthday, rs.Hour, rs.Minute, rs.Second).AddMonths(1);
            return nextday;
        }

        public DateTime getdateofnextyear(DateTime monthday)
        {
            //DateTime rs = DateTime.Now;
            DateTime nextday = monthday.AddYears(1);
            return nextday;
        }

        //function get the date like yyyy-MM-dd from a date value, we need compare the date change and store only date value from now datetime
        //first we need get standard string from now ->string1 = now.ToString("yyyy-MM-dd")
        //then we getback the date /test OK
        public DateTime getonlydate(DateTime datetimein)
        {
            DateTime rs = new DateTime();
            String standardstring = datetimein.ToString("yyyy-M-d");
            if (DateTime.TryParseExact(standardstring, "yyyy-M-d", null, System.Globalization.DateTimeStyles.None, out rs))
            {
                //MsgBox(date1.ToString)
            }
            else
            {
                Exception ex = new Exception();
                DateTime.TryParseExact("1 / 1 / 1900", "yyyy-M-d", null, System.Globalization.DateTimeStyles.None, out rs);
                //rs = CDate("1 / 1 / 1900");
                MessageBox.Show("function---- getonlydate---- error " + ex.ToString());
            }
            return rs;
        }
        public String getonlydate_str(DateTime datetimein)
        {
            return datetimein.ToString("yyyy-M-d");
        }
        //return the format MM/dd/yyyy hh:mm:ss tt
        public String getonlytimestr(DateTime datetimein)
        {
            return datetimein.ToString("h:m:s tt");
        }

        public String getonlydatestr(DateTime datetimein) {
            return datetimein.ToString("M/d/yyyy");
        }
        //this function is not fix tt word for any regional setting
        //How to fix tt word to any regional setting
        public DateTime getdatefromstandardformatstring(String stringin) {
            DateTime rs;
            if (DateTime.TryParseExact(stringin, "M/d/yyyy h:m:s tt", null, System.Globalization.DateTimeStyles.None, out rs)) {
            }
            else {
                MessageBox.Show("getdatefromstandardformatstring error ");
            }
            return rs;
        }

        //the function will reform a date string line MM/dd/yyyy hh:mm:ss tt 
        public String reformstardarddatestring(DateTime sDate, String timestring) {
            String monstr = sDate.Month.ToString();
            String daystr = sDate.Day.ToString();
            String yearstr = sDate.Year.ToString();
            return monstr + "/" + daystr + "/" + yearstr + " " + timestring;
        }


        public int getcurrentweekday() {
            return (int)DateTime.Now.DayOfWeek;
        }

        public int getcurrentmonthday() {
            return (int)DateTime.Now.Day;
        }


        //function will compare a timestring like hh:mm:ss tt with now greater or equal result will return true
        public bool CompareTimeStringWithCurrent(String timestring) {
            bool rs = false;
            String time1 = getonlydatestr(DateTime.Now) + " " + timestring;
            String time2 = getonlydatestr(DateTime.Now) + " " + getonlytimestr(DateTime.Now);
            //MsgBox("time1 = " & time1 & " " & "Time2 = " & time2)
            if (getdatefromstandardformatstring(time1) >= getdatefromstandardformatstring(time2)) {
                rs = true;
            }
            else {
                rs = false;
            }
            return rs;
           }


        //the inputarr will be indexed from 1
        public couplertypeV1 FindNextItem_in_aSet(couplertypeV1[] inputarr, int IntVal) {
            couplertypeV1 rs;
            couplertypeV1[] temparr = inputarr;
            int i;
            //Dim index As Integer = 0
            QuickSort(ref temparr, 1, temparr.GetUpperBound(0)); //sort ascending
            for (i = 0; i <= temparr.GetUpperBound(0); i++) {
                if (temparr[i].value_ > IntVal) {
                    rs = temparr[i];
                    rs.outrange = false;
                    return rs;
                }
            }
            rs = temparr[0];
            rs.outrange = true;
            return rs;
        }

        public TimeresultV1 FindNextItem_in_aSet(DateTime[] inputarr) {
            TimeresultV1 rs;
            DateTime[] temparr = inputarr;
            int i;
            //Dim index As Integer = 0
            QuickSort(ref temparr, 0, temparr.GetUpperBound(0));//sort ascending
            for (i = 0; i <= temparr.GetUpperBound(0); i++) {
                if (temparr[i] > DateTime.Now) {
                    rs.Time_ = temparr[i];
                    rs.outrange = false;
                    return rs;
                }
            }
            rs.Time_ = temparr[0];// loop back to beginning
            rs.outrange = true; // mean that current time is over the time point and need caculate new timepoint of next year
            return rs;
        }


        //this function will replace the year value of a date by the current year
        public DateTime ReplaceCurrentYearForDate(DateTime sDate) {
            DateTime rs;
            int sday = sDate.Day;
            String smonth = "0" + sDate.Month.ToString();
            String timestring = getonlytimestr(sDate);
            //MsgBox("Test AL.ReplaceCurrentYearForDate: " & smonth & "/" & sday & "/" & CStr(Now.Year) & " " & timestring)
            rs = getdatefromstandardformatstring(smonth + "/" + sday + "/" + DateTime.Now.Year.ToString() + " " + timestring);
            return rs;
        }

        //function relate to string bring multi field value, add, remove and check element into a string_field, each field isolated each other by seperator
        public bool checkexistingofInforstring_Fieldname(String Inforstring, String seperator, String GivenFieldvalue) {
            bool res;
            res = false;
            String[] arr1 = Inforstring.Split(new string[] { "seperator" }, StringSplitOptions.None);// (, )
            int i;
            for (i = 0; i <= arr1.GetUpperBound(0); i++) {
                if (arr1[i].ToLower() == GivenFieldvalue.ToLower()) {
                    res = true;
                    break;
                }
            }
            return res;
        }

        //if fieldname existed dont do anything
        public void AppendFieldForInforstring(ref String Inforstring, String GivenFieldvalue, String seperator) {
            if (checkexistingofInforstring_Fieldname(Inforstring, seperator, GivenFieldvalue) == true) {
            }
            else {
                String oldstring = Inforstring;
                String newstring;
                String newvalue = GivenFieldvalue;

                if (oldstring != "") {
                    newstring = oldstring + seperator + newvalue;
                }
                else {
                    newstring = newvalue;
                }
                Inforstring = newstring;
            }
        }

        // the structure of the resourcelinkstring is resourcename:recourcename$x$x$resourcename:recourcename
        //if dont find any resourcename will return -1
        public int FindindexofResourcelink(String resourcelinkstring, String resourcename) {
            int rs = -1;
            String[] resourcetemp = resourcelinkstring.Split(new string[] { "resourseperate" }, StringSplitOptions.None);//, )
            int i;
            for (i = 0; i <= resourcetemp.GetUpperBound(0); i++) {
                String resourcelink = resourcetemp[i];
                String[] resourcepart = resourcelink.Split(new string[] { "rsnamesep" }, StringSplitOptions.None);//, )
                if (resourcename == resourcepart[0]) {
                    return i;
                }
                //Exit For
            }

            return rs;
        }

        //this sun will find the exsting of the reourcename into the resourcelinkstring and add new if it not exsiting
        public void AddNewPartToResourceLinkString(ref String resourcelinkstring, String resourcename, String resourcelink) {
            if (FindindexofResourcelink(resourcelinkstring, resourcename) == -1) {
                String newpart = resourcename + rsnamesep + resourcelink;
                if (resourcelinkstring != "") {
                    resourcelinkstring = resourcelinkstring + resourseperate + newpart;
                }
                else {
                    resourcelinkstring = newpart;
                }
            }
        }

        public void updateresourcelink(ref String resourcelinkstring, String resourcename_old, String resourcelink_old, String resourcename_new, String resourcelink_new) {
            String oldpart = resourcename_old + rsnamesep + resourcelink_old;
            String newpart = resourcename_new + rsnamesep + resourcelink_new;
            resourcelinkstring = resourcelinkstring.Replace(oldpart, newpart);
        }


        public void deleteresourcelink(ref String resourcelinkstring, String resourcename_old, String resourcelink_old) {
            String oldpart = resourcename_old + rsnamesep + resourcelink_old;
            FF.DebugProcessStart("AL.deleteresourcelink", "E:/debug.txt",new string[] {resourcelinkstring, oldpart});
            if (oldpart != resourcelinkstring) {
                if (resourcelinkstring.IndexOf(oldpart) == 0) {
                    resourcelinkstring = resourcelinkstring.Replace(oldpart + resourseperate, "");// '123456
                }
                else {
                    resourcelinkstring = resourcelinkstring.Replace(resourseperate + oldpart, "");
                }
            }
            else {
                resourcelinkstring = "";
            }
            //MsgBox(resourcelinkstring)
        }


        public void RemoveFieldFromInforstring(ref String Inforstring, String GivenFieldvalue, String seperator) {
            String[] arr1 = Inforstring.Split(new string[] { seperator }, StringSplitOptions.None);
            String newstring = "";
            for (int i = 0; i <= arr1.GetUpperBound(0); i++) {
                if (arr1[i] != GivenFieldvalue) {
                    if (i == 0) {
                        newstring = arr1[i];
                    }
                    else {
                        newstring = newstring + seperator + arr1[i];
                    }
                }
            }
            Inforstring = newstring;
        }


        public String[] GetFieldSet(String Inforstring, String seperator) {
            String[] rs;
            rs = Inforstring.Split(new string[] { seperator }, StringSplitOptions.None);
            return rs;
        }

        public void removeobjectfromcollection(ref ArrayList col, TreeNode obj) {
            int indexfound = 0;
            for (int i = 0; i < col.Count; i++) {
                if (col[i] == obj) {
                    indexfound = i;
                }
            }
            if (indexfound != 0) {
                col.Remove(indexfound);
            }
        }


        public void collectiontransfer(ArrayList sourcex, ref ArrayList desX) {
            desX.Clear();
            for (int i = 0; i < sourcex.Count; i++) {
                desX.Add(sourcex[i]);
            }
        }


}

   

}
