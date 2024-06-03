package PatternsGOF.Lab6.Problem7;

import java.util.Date;

public class DateHelperExtended extends DateHelper {

    public static long getDaysDifference(Date date1, Date date2) {
        long diffInMillies = Math.abs(date2.getTime() - date1.getTime());
        return diffInMillies / (24 * 60 * 60 * 1000);
    }

    public static void main(String[] args) {
        Date date1 = new Date();
        Date date2 = addDays(date1, 5);
        long difference = getDaysDifference(date1, date2);
        System.out.println("Difference in days: " + difference);
    }
}
