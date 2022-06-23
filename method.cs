Dictionary<string, Array> OptParams = new Dictionary<string, Array>();
OptParams.Add("period", new[] { 1, 2, 3 });
OptParams.Add("v", new[] { 4, 5, 6 });
int total_params = OptParams.Keys.ToList().Sum(x => OptParams[x].Length);
for(int i = 0; i < total_params; i++)
{
    string ot = "";
    foreach(var k in OptParams.Keys)
    {
        ot += k +": "+ OptParams[k].GetValue(i / (OptParams[k].Length - 1)) + " , ";
    }
    Console.WriteLine(ot);
}

