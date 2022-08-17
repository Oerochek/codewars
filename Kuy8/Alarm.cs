﻿/*
 Write a function named setAlarm which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.

 The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise. Examples:

 setAlarm(true, true) -> false
 setAlarm(false, true) -> false
 setAlarm(false, false) -> false
 setAlarm(true, false) -> true
*/
public class Kata
{
    public static bool SetAlarm(bool e, bool v)
    {
        if (e == true && v == true) {
            return false;
        }

        if (e == false && v == true)
      return false;

        if (e == false && v == false)
      return false;

        if (e == true && v == false)
      return true;
        return false;
    }
}
/*а ведь рили можно было так
public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) => employed && !vacation;
}
*/