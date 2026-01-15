using System;
namespace CounterDemo
{
class Counter
    {
        public int[] data;
        public int cnt1 = 0;
        public int cnt0 = 0;

        public Counter(int[] data)
        {
            this.data = data;
        }

        public string getCount()
        {


            try
            {
                foreach (var item in data)
                {
                    if (item == 0)
                    {
                        cnt0 = cnt0 + 1;
                    }
                    else
                    {
                        cnt1 = cnt1 + 1;
                    }
                }



                if (cnt0 % 2 != 0 && cnt1 % 2 == 0)
                {
                    throw new ExceptionZero("Zero comes odd times");
                }
                if (cnt0 % 2 == 0 && cnt1 % 2 != 0)
                {
                    throw new ExceptionOne("One comes odd times");
                }
                else
                {
                    return "Great";
                }


            }
            catch (ExceptionZero e)
            {
                //Console.WriteLine(e.Message);
                return e.Message;
            }
            catch (ExceptionOne e)
            {
                return e.Message;
            }
        }
    }

    class ExceptionZero : Exception
    {
        public ExceptionZero()
        {

        }
        public ExceptionZero(string message) : base(message)

        {

        }

    }
    class ExceptionOne : Exception
    {
        public ExceptionOne()
        {

        }
        public ExceptionOne(string message) : base(message)

        {

        }

    }

    class Sample
    {
        public static void Main()
        {
            int[] data = { 0, 1, 0, 1, 0, 1, 1, 0, 1 };
            Counter c = new Counter(data);
            string res = c.getCount();
            Console.WriteLine(res);
        }
    }
}