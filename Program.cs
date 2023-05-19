using System;
class MainClass {
    public static void Main (string[] args) {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int N = int.Parse(inputs[0]);
        int K = int.Parse(inputs[1]);
        input = Console.ReadLine();
        inputs = input.Split(' ');
        int[] population = new int[N];
        for (int i = 0; i < N; i++) {
            population[i] = int.Parse(inputs[i]);
        }
        int maxCustomers = 0;
        for (int i = 0; i < N; i++) {
            int totalCustomers = 0;
            for (int j = i - K; j <= i + K; j++) {
                if (j >= 0 && j < N) {
                    totalCustomers += population[j];
                }
            }
            if (totalCustomers > maxCustomers) {
                maxCustomers = totalCustomers;
            }
        }
        Console.WriteLine(maxCustomers);
    }
}