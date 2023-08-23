import React from 'react';
import { Button, Card, Form, Input } from 'antd';
import { ILogin } from 'models/ILogin';
import axios from 'axios';
import { IAuthResult } from 'models/IAuthResult';
import { useNavigate } from 'react-router-dom';
import jwtDecode from 'jwt-decode';
import { IUserToken } from 'models/IUserToken';
import { AuthContext } from 'contexts/AuthContext';

type Props = {};

const LoginPage = (props: Props) => {
  const [form] = Form.useForm<ILogin>();
  const authContext = React.useContext(AuthContext);
  const navigate = useNavigate();
  const onLogin = async () => {
    try {
      form.submit();
      const loginValue = await form.validateFields();
      const loginResponse = await axios.post<IAuthResult>('/api/authentication/login', loginValue);
      const authResult = loginResponse.data;
      localStorage.setItem('access-token', authResult.accessToken);
      const userToken = jwtDecode<IUserToken>(authResult.accessToken);
      console.log(userToken);
      authContext.login(userToken);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <Card style={{ width: 500 }}>
      <Form form={form}>
        <Form.Item name="userName" label="نام کاربری">
          <Input />
        </Form.Item>
        <Form.Item name="password" label="کلمه عبور">
          <Input.Password />
        </Form.Item>
        <Button onClick={() => onLogin()}> ورود به سیستم </Button>
      </Form>
    </Card>
  );
};

export default LoginPage;
