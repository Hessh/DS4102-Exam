<template>
  <section class="login">
    <LoginForm></LoginForm>
    <CreateUser></CreateUser>
  </section>
</template>

<script>
import LoginForm from "../components/login/LoginForm";
import CreateUser from "../components/login/CreateUserForm";

export default {
  name: "Login",
  components: {
    LoginForm,
    CreateUser
  },
  beforeCreate() {
    if (document.cookie) {
      let cookies = document.cookie.split(";");
      if (cookies.length > 1) {
        return "";
      } else {
        let loginCookie = cookies[0].split("=");
        if (loginCookie[0] == "login") {
          this.$router.push({ name: "Account" });
        }
      }
    }
  }
};
</script>

<style scoped>
.login {
  position: relative;
  width: 100%;
  max-width: 800px;
  margin: 0 auto;
  display: grid;
  grid-template-columns: 1fr;
  gap: 20px 40px;
  align-items: flex-start;
  padding: 40px;
}

@media only screen and (min-width: 800px) {
  .login {
    grid-template-columns: repeat(2, 1fr);
    padding: 40px 0;
  }
}
</style>