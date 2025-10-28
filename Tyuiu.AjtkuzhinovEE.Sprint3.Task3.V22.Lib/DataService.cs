using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AjtkuzhinovEE.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            int res = 0;
            int count = 0;
        
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    count++;
                }
                else
                {
                    res = Math.Max(res, count);
                    count = 0;
                }
            }
            return res;
        }
    }
}
