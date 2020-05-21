namespace IzsekovanjeRondelic.Db
{
   
    public class Slug
    {
        public int id { get; set; }
        public decimal lenght { get; set; }
        public decimal width { get; set; }
        public decimal radious { get; set; }
        public decimal space { get; set; }
        public decimal result { get; set; }


        public override string ToString()
        {
            return "Nov izraèun : " + lenght + " " + width + " " + radious + " " + space + " rezultat: " + result;
        }
    }
}
