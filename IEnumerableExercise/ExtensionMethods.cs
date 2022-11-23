namespace IEnumerableExercise
{
    internal static class ExtensionMethods
    {
        internal static IEnumerable<T> Filter<T>(this IEnumerable<T> user,
            Func<T, bool> filter)
        {
            var listFilter = new List<T>();
            using var enumerator = user.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (filter(enumerator.Current))
                {
                    listFilter.Add(enumerator.Current);
                }
            }
            return listFilter;
        }

        internal static IEnumerable<T> Map<T>(this IEnumerable<T> user,
            Func<T, T> filter)
        {
            var listFilter = new List<T>();
            using var enumerator = user.GetEnumerator();
            while (enumerator.MoveNext())
            {
                listFilter.Add(filter(enumerator.Current));
            }
            return listFilter;
        }
        internal static void ListData<T>(this IEnumerable<T> users)
        {
            var listUser = users.Cast<User>().ToList();
            foreach (var user in listUser)
            {
                Console.WriteLine($"{user.Id} {user.Name} {user.Country}");
            }
        }
    }
}
