import React from 'react'
import { Outlet } from 'react-router-dom'

import { UploadOutlined, UserOutlined, VideoCameraOutlined } from '@ant-design/icons';
import { Layout, Menu, theme } from 'antd';

const { Header, Content, Footer, Sider } = Layout;

type Props = {}

const MainLayout = (props: Props) => {
  const
    {
      token: { colorBgContainer },
    } = theme.useToken();
  return (
    <>
      <Layout style={{ height: "100vh" }}>
        <Header style={{ display: 'flex', alignItems: 'center' }}>
          <div style={{color:"white", textDecoration:"underline"}}>
            <h2>پنل ادمین فروشگاه نان</h2>
          </div>
          <Menu
            theme="dark"
            mode="horizontal"
          />
        </Header>
        <Layout>
          <Sider
            breakpoint="lg"
            collapsedWidth="0"
          >
            <Menu
              theme="dark"
              mode="inline"
              defaultSelectedKeys={['4']}
              items={[UserOutlined, VideoCameraOutlined, UploadOutlined, UserOutlined].map(
                (icon, index) => ({
                  key: String(index + 1),
                  icon: React.createElement(icon),
                  label: `nav ${index + 1}`,
                }),
              )}
            />
          </Sider>
          <Layout>
            <Content style={{ margin: '24px 16px 0' }}>
              <div style={{ padding: 24, minHeight: 360, background: colorBgContainer }}>
                <Outlet />
              </div>
            </Content>
            <Footer style={{ textAlign: 'center' }}>ABA Design ©2023 Created by ABA's BOSS</Footer>
          </Layout>
        </Layout>
      </Layout>

    </>
  )
}

export default MainLayout