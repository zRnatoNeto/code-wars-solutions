namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      string output = "";
      for(int i = 0; i< n;i++)
        output += s;
      return output;
    }
  }
}