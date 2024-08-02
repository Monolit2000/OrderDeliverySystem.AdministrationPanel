
function showNotification(message, type) {
    var container = document.getElementById('notification-container');
    var notification = document.createElement('div');
    notification.className = 'notification';
    notification.innerText = message;
    notification.style.backgroundColor = type === 'error' ? '#ffcccc' : '#ccffcc'; 

    container.appendChild(notification);
    setTimeout(function () {container.removeChild(notification);}, 4000);
}



function toggleWeek(weekId) {
    const weekContent = document.getElementById(weekId);
    if (weekContent.style.display === "none") {
        weekContent.style.display = "block";
    } else {
        weekContent.style.display = "none";
    }
}