
function showNotification(message, type) {
    var container = document.getElementById('notification-container');
    var notification = document.createElement('div');
    notification.className = 'notification';
    notification.innerText = message;
    notification.style.backgroundColor = type === 'error' ? '#ffcccc' : '#ccffcc'; 

    container.appendChild(notification);
    setTimeout(function () {container.removeChild(notification);}, 4000);
}
