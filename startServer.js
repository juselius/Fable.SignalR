const { spawn } = require('child_process')

const runServer = () => {
    console.log("Starting server...")

    const ps = spawn('dotnet', ['run', '-p', './demo/Server/Server.fsproj'])

    ps.stdout.on('data', (data) => {
        console.log(data.toString())
    })

    ps.stderr.on('data', (data) => {
        console.error(data.toString())
    })
}

runServer()

