//--Start of task timing stuff

var startTime, endTime;

function StartTimedTask(){
    startTime = new Date().getTime();
}

function EndTimedTask(){
    endTime = new Date().getTime();
    return (endTime - startTime); //calculate time taken
}

//--End of task timing stuff
//--Start of per-task GUI stuff

function updateTaskInfoBox(headerText, bodyText) {
    $("#task-outliner > .card-header").text(headerText);
    $("#task-outliner > .card-body").text(bodyText);
}

//--End of per-task GUI stuff
