open Fake.Core
open Fake.IO
open Farmer
open Farmer.Builders

open Helpers

initializeContext()

let srcPath  = Path.getFullName "src/Fable.SignalR.Elmish"
let libPath  = Some srcPath

let distPath  = Path.getFullName "dist"
let packPath    = Path.getFullName "packages"

Target.create "Clean" (fun _ -> Shell.cleanDir distPath)

Target.create "InstallClient" (fun _ ->
    run npm "install" "."
    run dotnet "tool restore" "."
)

Target.create "Bundle" (fun _ ->
    run dotnet $"publish -c Release -o \"{distPath}\"" srcPath
)

Target.create "BundleDebug" (fun _ ->
    run dotnet $"publish -c Debug -o \"{distPath}\"" srcPath
)

Target.create "Pack" (fun _ ->
    match libPath with
    | Some p -> run dotnet $"pack -c Release -o \"{packPath}\"" p
    | None -> ()
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
