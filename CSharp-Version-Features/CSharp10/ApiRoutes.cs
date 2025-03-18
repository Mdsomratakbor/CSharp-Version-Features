namespace CSharp10;

public static class ApiRoutes
{
    // Base API path
    private const string ApiBase = "/api";

    public static class Library
    {
        /// <summary>
        /// The base route for library API.
        /// </summary>
        private const string Base = ApiBase + "/library"; // Concatenation (valid in earlier versions)

        /// <summary>
        /// The route for getting a library by ID.
        /// This uses string interpolation to dynamically insert a GUID in the route.
        /// </summary>
        private const string GetById = $"{ApiBase}/{{id:guid}}"; // String interpolation (C# 10 feature)

        /// <summary>
        /// The route for getting all libraries.
        /// </summary>
        private const string GetAll = ApiBase + "/library"; // Concatenation (valid in earlier versions)

        // New example using const string interpolation (C# 10 feature)
        /// <summary>
        /// The route for searching libraries with a specific name.
        /// This demonstrates const string interpolation where all placeholders are constants.
        /// </summary>
        private const string SearchByName = $"{ApiBase}/library/search/{{name}}"; // String interpolation (C# 10 feature)

        /// <summary>
        /// Gets the base route for the library API.
        /// </summary>
        public static string GetBase() => Base;

        /// <summary>
        /// Gets the route for getting a library by ID.
        /// </summary>
        public static string GetByIdRoute() => GetById;

        /// <summary>
        /// Gets the route for getting all libraries.
        /// </summary>
        public static string GetAllRoute() => GetAll;

        /// <summary>
        /// Gets the route for searching libraries by name.
        /// </summary>
        public static string GetSearchByNameRoute() => SearchByName;
    }
}
