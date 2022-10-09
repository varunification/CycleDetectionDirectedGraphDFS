

LinkedList<int>[] adj = new LinkedList<int>[10];

for (int i = 0; i < 10; i++)
{
    adj[i] = new LinkedList<int>();
}

adj[1].AddLast(2);
adj[2].AddLast(3);
adj[3].AddLast(4);
adj[3].AddLast(6);
adj[4].AddLast(5);
adj[5].AddLast(4);
 

bool[] isvis= new bool[10];
bool[] dfsvis = new bool[10];

bool flag = false;
for(int i = 1; i <= 9; i++)
{
    if (!isvis[i])
    {
        if (checkCycle(i))
        {
            flag = true;
        }
    }
}

if (flag)
{
    Console.WriteLine("the cycle is present in the graph");
}


bool checkCycle(int s)
{
    if(isvis[s] && dfsvis[s])
    {
        return true;
    }
   



        isvis[s] = true;
        dfsvis[s] = true;

        foreach (var nodes in adj[s])
        {
        
            if (checkCycle(nodes))
            {
                return true;
            }
            
        
            
        }

    dfsvis[s] = false;

    return false;
}








