package PatternsGOF.Lab6.Problem7;

import java.util.Calendar;
import java.util.Date;

public class DateHelper {

    public static Date addDays(Date date, int days) {

        Calendar calendar = Calendar.getInstance();
        calendar.setTime(date);
        calendar.add(Calendar.DAY_OF_YEAR, days);
        return calendar.getTime();
    }

    // Інші методи класу...
}
