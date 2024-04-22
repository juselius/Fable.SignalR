open Fake.Core
open Fake.IO
open Farmer
open Farmer.Builders

open Helpers

initializeContext()

let modules = [
        "Fable.SignalR.Elmish"
        "Fable.SignalR.Saturn"
    ]

let modPath (m: string) = Path.getFullName $"src/{m}"

let distPath = Path.getFullName "dist"
let packPath = Path.getFullName "packages"

Target.create "Clean" (fun _ -> Shell.cleanDir distPath)

Target.create "InstallClient" (fun _ ->
    run npm "install" "."
    run dotnet "tool restore" "."
)

Target.create "Bundle" (fun _ ->
    modules
    |> List.iter (fun m ->
        let src = modPath m
        run dotnet $"publish -c Release -o \"{distPath}/{m}\" -f net8.0" src)
)

Target.create "BundleDebug" (fun _ ->
    modules
    |> List.iter (fun m ->
        let src = modPath m
        run dotnet $"publish -c Debug -o \"{distPath}/{m}\" -f net8.0" src)
)

Target.create "Pack" (fun _ ->
    modules
    |> List.iter (fun m ->
        let src = modPath m
        run dotnet $"pack -c Release -o \"{packPath}\"" src)
)

Target.create "Format" (fun _ ->
    run dotnet "fantomas . -r" "src"
)

open Fake.Core.TargetOperators

let dependencies = [
    "Clean"
        ==> "InstallClient"
        ==> "Bundle"

    "Clean"
        ==> "BundleDebug"


    "Clean"
        ==> "Pack"
]

[<EntryPoint>]
let main args = runOrDefault args
