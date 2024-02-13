namespace CryptoScanner.App.Filtering
{
    public class FilteringThings
    {
        // List<int> numbers = new List<int> { 1, 14, 12, 1100, 99 }

        // var orderedNumbers = numbers.OrderBy(n => n).ToList(); // Sorterar och konverterar till lista


        public List<string> OrderByNameAscending(List<string> names)
        {
            List<string> orderedNamesAscending = names.OrderBy(n => n).ToList();
            return orderedNamesAscending;
        }

        public List<string> OrderByNameDescending(List<string> names)
        {
            List<string> orderedNamesDescending = names.OrderByDescending(n => n).ToList();
            return orderedNamesDescending;
        }
    }



}
