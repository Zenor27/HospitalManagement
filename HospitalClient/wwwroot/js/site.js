function setActivePage(currentPage) {
    var ctx = document.getElementById(currentPage);
    ctx.classList.add('active');
}

function setStatCardArrows() {
    // Get all stats cards
    const classList = document.getElementsByClassName('stat-last-hours');
    for (var i = 0; i < classList.length; i++) {
        const currentClass = classList[i];
        // Check if it is an int
        const statValue = parseInt(currentClass.innerText);
        if (isNaN(statValue))
            continue;

        const isPositive = statValue >= 0;
        const parentClass = currentClass.parentElement;
        if (isPositive) {
            parentClass.classList.add('fa-arrow-up');
        } else {
            parentClass.classList.add('fa-arrow-down');
        }
        parentClass.parentElement.classList.add(isPositive ? 'text-success' : 'text-danger');
    }
}