workflow "New workflow" {
  on = "push"
  resolves = ["Build and run tests"]
}

action "Build and run tests" {
  uses = "docker://yaakovh/github-action-dotnet-test"
}
