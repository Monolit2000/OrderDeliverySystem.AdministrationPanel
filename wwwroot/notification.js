window.showNotification = (message, type) => {
    const notification = document.querySelector('.notification');
    notification.textContent = message;
    notification.className = `notification ${type.toLowerCase()}`;
    notification.style.display = 'block';

    setTimeout(() => {
        notification.style.display = 'none';
    }, 2000); // Исчезает через 2 секунды
};