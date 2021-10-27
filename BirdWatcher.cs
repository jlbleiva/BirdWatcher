using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastweek = new[] { 0, 2, 5, 3, 7, 8, 4 };
        return lastweek;

    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]+=1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int element in birdsPerDay)
        {
            if (element == 0) return true;
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalbirds=0;
        for (int i=0; i < numberOfDays; i++)
        {
            totalbirds += birdsPerDay[i];
        }

        return totalbirds;
    }

    public int BusyDays()
    {
        int busydays = 0;
        foreach (int element in birdsPerDay)
        {
            if (element >= 5) busydays += 1;
        }

        return busydays;
    }
}
