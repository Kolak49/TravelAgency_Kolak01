document.addEventListener('DOMContentLoaded', function () {
    window.addEventListener('scroll', function () {
        var header = this.document.getElementById('header-top');
        var scrolltop = window.scrollY;
        var maxScroll = 250;

        var opacity = Math.min(scrollTop / maxScroll, 1)
        header.style.backgroundColor = `rgba(255, 165, 0, ${opacity})`;

    });

});
function toggleMenu() {
    const sideMenu = document.getElementById('side-menu');
    sideMenu.classList.toggle('active');
}
document.getElementById('hamburger').addEventListener('click', toogleMemu);

