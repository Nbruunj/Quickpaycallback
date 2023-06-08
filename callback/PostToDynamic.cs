namespace callback
{
    public class PostToDynamic
    {
        public async Task postdata(string id, string status)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Patch, $"https://org22b50cb8.crm4.dynamics.com/api/data/v9.2/nal_kursuses({id})");
            string json = $"\r\n{{\r\n    \r\n    \"nal_paymentstatus\": \"{status}\"\r\n    \r\n\r\n}}";
            request.Headers.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyIsImtpZCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyJ9.eyJhdWQiOiJodHRwczovL29yZzIyYjUwY2I4LmNybTQuZHluYW1pY3MuY29tLyIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0L2ViNmY0NGM1LTVkZTktNDI4YS1hNDhkLWE4NGI4NmFhNzRhNS8iLCJpYXQiOjE2ODAwMTA1NDMsIm5iZiI6MTY4MDAxMDU0MywiZXhwIjoxNjgwMDE1NDU2LCJhY3IiOiIxIiwiYWlvIjoiQVRRQXkvOFRBQUFBOUtZbWlQZUNoMmhvMWhlVnhpYURMcjI1b1UzQjdLeUFUR21FNlIyTjg2ZUg4YjFOa3ZxQWQyS25lSkltckVmNiIsImFtciI6WyJwd2QiXSwiYXBwaWQiOiIwMDEyOGI1ZS04N2FhLTQ1MTktYjM2NS1mNWU1MjgwMGZhNTciLCJhcHBpZGFjciI6IjAiLCJmYW1pbHlfbmFtZSI6IkFkbWluaXN0cmF0b3IiLCJnaXZlbl9uYW1lIjoiU3lzdGVtIiwiaXBhZGRyIjoiODcuNTQuNDYuMjAyIiwibmFtZSI6IlN5c3RlbSBBZG1pbmlzdHJhdG9yIiwib2lkIjoiYjliNmFhNzctMzkzOC00Y2EzLWE5YzEtNDM1MGU0NWIyMjIxIiwicHVpZCI6IjEwMDMyMDAyNjU2QjYyRDMiLCJyaCI6IjAuQVVzQXhVUnY2LWxkaWtLa2phaExocXAwcFFjQUFBQUFBQUFBd0FBQUFBQUFBQUJMQUdBLiIsInNjcCI6InVzZXJfaW1wZXJzb25hdGlvbiIsInN1YiI6IkdDM19XRmp2aFQ0RkxGY1pLOHdMUzdzLWlCVHZiVXdjNjFRbUd4V21VVkEiLCJ0aWQiOiJlYjZmNDRjNS01ZGU5LTQyOGEtYTQ4ZC1hODRiODZhYTc0YTUiLCJ1bmlxdWVfbmFtZSI6ImFkbWluQENSTTU2NTE4OC5vbm1pY3Jvc29mdC5jb20iLCJ1cG4iOiJhZG1pbkBDUk01NjUxODgub25taWNyb3NvZnQuY29tIiwidXRpIjoiYktzYkxpeWpSa3lyeHhDM0pmTklBQSIsInZlciI6IjEuMCJ9.L4VxCp_WXwSQHEDFC918Z5M7x8D8dRaaciji8NiIQLC0kxRqnJ4af7R1zoK9jTFz6KQ09cRySn3hWJIl7GvOR7WefgYI9heKZrXZEruI0ZCLBah2CuO8txhG0Qoax55LoupoKk2ma6QUb1Lta2swv_04Ulwt_PXYOgs7pBEc_CQi97cVxg_wLo5SXhUurw0O6ZjLfPKqdIlBc9zItvtFLD1lplXu8WgA_OAy7yIy49wuJv1qy6HEnWPH1shHMWegaaRE5bT2iY1FexmiWSD5KUAgY54mvWBQ8ZL61rE6izlJNWldoaVQA7nFXOd3wOc8Iv87h4zNr5Cm-DPDZ-yL2Q");
            request.Headers.Add("Cookie", "ARRAffinity=d9524d93915fd054d4da1937387e78a631b558ee43ae6af7e6f5ee8a6b9317df15134d20c556b0b34b9b6ae43ec3f5dcdad61788de889ffc592af7aca85fc1c508DB2F5E3A26E4EA536715717; ReqClientId=4020e502-a7c8-47f9-910b-e4b6494ce732; orgId=42e192b4-059d-4b50-8ebc-3dec4e8c1a61"); var content = new StringContent(json, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
