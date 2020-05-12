# GraphQL-ASP.NET-WebAPI

based on example:
 https://github.com/graphql-dotnet/examples/tree/master/src/AspNetWebApi


 how it works?

 open Chrome with GraphQL extension (from here: https://chrome.google.com/webstore/detail/graphql-playground-for-ch/kjhjcgclphafojaeeickcokfbhlegecd), open URL (for example local one in debug mode: https://localhost:44354/api/GraphQL) and issue this query:

query foo { hero { id name appearsIn } }

and the answer will be:

{
  "data": {
    "hero": {
      "id": "3",
      "name": "R2-D2",
      "appearsIn": [
        "NEWHOPE",
        "EMPIRE",
        "JEDI"
      ]
    }
  }
}

 
 note: Star Wars selected as data not only because it is widely known but because official website of GraphQL uses it in query examples: 
 https://graphql.org/learn/queries/
