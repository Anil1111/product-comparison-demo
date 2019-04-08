document.addEventListener('DOMContentLoaded', () => {
    window.compareLanding = new Vue({
        el: '#compare-landing',
        router: new VueRouter({
            mode: "history"
        }),
        data: {
            selectedBeverages: []
        },
        mounted: function () {
            var query = this.$route.fullPath.replace(this.$route.path, "");

            this.$http.get(`/api/compare/beverages${query}`)
                .then(response => {
                    this.selectedBeverages = response.data.Beverages;
                }).catch((error) => {
                    console.log(error);
                });
        }
    });
}); 