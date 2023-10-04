import Welcome from "./views/Welcome.vue"
import { createRouter,createWebHashHistory } from 'vue-router';

const routes =[
    {
        path:"/",
        name:'Welcome',
        component:Welcome
    },
    ]
const router = createRouter({
    history:createWebHashHistory(),
    routes
});

export default router;