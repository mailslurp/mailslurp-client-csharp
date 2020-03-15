
FROM mono

COPY . .

RUN nuget restore -PackagesDirectory src/mailslurp/packages src/mailslurp
RUN nuget pack -Build -OutputDirectory out src/mailslurp/mailslurp.nuspec
RUN nuget push out/mailslurp.7.0.6.nupkg -ApiKey oy2mpuyihauyeij57hwaif5ntz7pctgexdzwrz3ftrihze -Source https://api.nuget.org/v3/index.json

