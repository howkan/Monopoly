var serviceCollection = new ServiceCollection();

serviceCollection.AddServices();

var servicesProvider = serviceCollection.BuildServiceProvider();

var palletService = servicesProvider.GetRequiredService<IPalletService>()!;

var pallets = palletService.GetPallets(3);

ShowMessage("Список паллетов:\n");

ShowPallets(pallets);

ShowMessage("1) Отсортировать по сроку годности:\n");

pallets = palletService.GroupByExpirationAt(pallets);

ShowPallets(pallets);

ShowMessage("2) Отсортировать по сроку годности и весу:\n");

pallets = palletService.GroupByExpirationAtAndWeight(pallets);

foreach (var pallet in pallets) Console.Write($"{pallet}\n---\n");

ShowMessage("3) Отсортировать по сроку годности и объёму:\n");

pallets = palletService.GroupByExpirationAtAndVolume(pallets);

ShowPallets(pallets);

Console.ReadKey();

void ShowPallets(IEnumerable<Pallet> pallets)
{
    foreach (var pallet in pallets)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Паллет:\n");
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write($"{pallet}\n---\n");
    }
}

void ShowMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}