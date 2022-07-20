let students = ["Justin", "Josh", "Brandon", "Vinh", "Daniel", "Kris", "Matt", "Connor", "Asia", "Krista","Travis", "Mara", "Robot","Ali"];

DisplayRemaining();


function getRandomStudent(){
    let rando = Math.floor(Math.random()*students.length);
    console.log(rando);
    let stu = students[rando];
    students.splice(rando,1);
    return stu;
}
function DisplayRemaining(){
    document.getElementById("remaining").innerText = "";
    students.forEach(s => {
        document.getElementById("remaining").innerHTML += s + "<br />";
    })
}

function DisplayStudent(){
    document.getElementById("display").innerText = getRandomStudent();

    DisplayRemaining();
}