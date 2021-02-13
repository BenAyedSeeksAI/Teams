namespace Teams
{
    partial class Program
    {
        class Team
        {
            public string name;
            public int fixtureCount;
            public int[] record;
            public int goalsFor;
            public int goalsAgainst;
            public int p;


            public Team(string name) 
            {
                this.name = name;
                record = new int[] { 0, 0, 0 };
                fixtureCount = 0; 
            }
            public void win(int goalsFor, int goalsAgainst)
            {
                fixtureCount++;
                record[0]++;
                this.goalsFor += goalsFor;
                this.goalsAgainst += goalsAgainst;
                calculatePoints();
            }
            public void draw(int goalsFor, int goalsAgainst)
            {
                fixtureCount++;
                record[1]++;
                this.goalsFor += goalsFor;
                this.goalsAgainst += goalsAgainst;
                calculatePoints();
            }
            public void lose(int goalsFor, int goalsAgainst)
            {
                fixtureCount++;
                record[2]++;
                this.goalsFor += goalsFor;
                this.goalsAgainst += goalsAgainst;
                calculatePoints();
            }
            public int calculatePoints()
            {
                int value = (record[0] * 3) + record[1];
                p = value; 
                return value;
            }
            
            public string result()
            {
                string points = p.ToString();
                string win = record[0].ToString();
                string draw = record[1].ToString();
                string lose = record[2].ToString();
                string answer = name + " Points : " + points + " win : " + win + " draw : " + draw + " lose : " + lose;
                return answer;
            }
        }
    }
}
