public class app {
    public static void main(String[] args) {
        checkSumSign();
    }
    public static void checkSumSign() {
        int firstNum = 15;
        int secondNum = 4;
        int sum = firstNum + secondNum;
        if (sum >= 0)
            System.out.println("Сумма положительная");
        else
            System.out.println("Сумма отрицательная");
    }
}
