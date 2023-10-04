import './assets/main.css'
import router from './router.js'
import { createApp } from 'vue'
import App from './App.vue'

const app = createApp(App)
app.mount('#app')
app.use(router);


