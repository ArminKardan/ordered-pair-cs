Dictionary<string, Array> OptParams = new Dictionary<string, Array>();
OptParams.Add("x", new[] { 1, 2, 3 });
OptParams.Add("y", new[] { 4, 5, 6 });
OptParams.Add("z", new[] { 7, 8 });
var keys = OptParams.Keys.ToList();
var values = OptParams.Values.ToList();
int total_params = OptParams.Keys.ToList().Aggregate(1, (acc, x) => acc * OptParams[x].Length);
Func<Dictionary< string, Array >,int, int> remlen = (dic, i) =>
{
    int res = 1;
    var kes = dic.Keys.ToList();
    for (int t = i + 1; t < dic.Keys.Count; t++)
    {
        res *= dic[kes[t]].Length;
    }
    return res;
};
for (int i = 0; i < total_params; i++)
{
    string ot = "";
     for (int cat_index = 0; cat_index < keys.Count; cat_index++)
     {
         var rl = remlen(OptParams, cat_index);
         var cat_len = values[cat_index].Length;
         var index = (i / rl) % cat_len;
         ot += keys[cat_index] + ": " + OptParams[keys[cat_index]].GetValue(index) + " , ";
     }
     Console.WriteLine(ot);
}
