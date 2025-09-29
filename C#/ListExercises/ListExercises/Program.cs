using System.Reflection.Metadata.Ecma335;

int sum(List<int> nums)
{
    int tot = 0;
    foreach (int i in nums)
    {
        tot += nums[i];
    }
    return tot;
}

int Max(List<int> nums)
{
    int max = int.MinValue;
    foreach (int i in nums)
    {
        if (max > nums[i])
        {
            max = i;
        }
    }
    return max;
}
int Min(List<int> nums)
{
    int min = int.MaxValue;
    foreach (int i in nums)
    {
        if (min < nums[i])
        {
            min = i;
        }
    }
    return min;
}
List<int> negatives(List<int> nums)
{
    List<int> negs = [];
    foreach (int i in nums)
    {
        if (nums[i] < 0)
        {
            negs.Add(nums[i]);
        }
    }
    return negs;
}
void printlist(List<string> list)
{
    foreach (string s in list)
    {
        Console.WriteLine(s);
    }
}
bool samelist(List<int> l1, List<int> l2)
{
    for (int i = 0; i< l1.Count;i++)
    {
        if (l1[i] == l2[i])
        {
            continue;
        }
        else
        {
            return false;
        }
    }
    return true;
}
// Console.WriteLine(samelist([1, 2, 3], [1, 2, 3]));

bool sameitems<T>(List<T> l1, List<T> l2)
{
    foreach (T i in l1)
    {
        if (l2.Contains(i))
        {
            continue;
        }
        else
        {
            return false;
        }
    }
    return true;
}
// Console.WriteLine(sameitems([1, 2, 3], [4, 2, 1]));

bool naivesearch(List<int> nums, int n)
{
    foreach (int i in nums)
    {
        if (i == n)
        {
            return true;
        }
    }
    return false;
}
// Console.WriteLine(naivesearch([1, 2, 3], 3));

bool binarysearch(List<int> nums, int n, int min, int max)
{
        if (min > max)
        {
            return false;
        }
        int mid = (min+max)/2;
        if (nums[mid] == n)
        {
            return true;
        }
        else if (nums[mid]<n)
        {
            return binarysearch(nums, n, mid + 1, max);
        }
        else
        {
            return binarysearch(nums, n, min, mid - 1);
        }
   
}
Console.WriteLine(binarysearch([1, 2, 3, 4, 5], 3, 0,4));